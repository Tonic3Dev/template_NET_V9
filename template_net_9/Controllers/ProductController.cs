﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using static template_net_9.Utils.Constants;
using template_net_9.DTOs;
using template_net_9.Services;

namespace template_net_9.Controllers
{

    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        private readonly ProductServices _productServices;
        public ProductController(ProductServices productsService)
            {
                this._productServices = productsService;
            }

            /// <summary>
            ///  Get Products
            /// </summary>
            /// <param name="baseFilter"></param>
            /// <returns></returns>
            [HttpGet]
            public async Task<ActionResult<ListResponse<ProductDTO>>> GetProducts(
                [FromQuery] BaseFilter baseFilter)
            {
                return await _productServices.GetProducts(baseFilter);
            }


            /// <summary>
            ///  Get product by id
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            [HttpGet("{id}")]
            public async Task<ActionResult<ProductDTO>> GetProductById(
                [FromRoute] string id)
            {
                var response = await _productServices.GetProductById(id);

                if (response == null) return NotFound("Product not found");
                return response;
            }

            /// <summary>
            ///  Create a product
            /// </summary>
            /// <param name="productCreationDTO"></param>
            /// <returns></returns>
            [HttpPost(Name = "CreateProduct")]
            [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
            public async Task<ActionResult<ProductDTO>> CreateProduct(
                [FromForm] ProductCreationDTO productCreationDTO)
            {
                var response = await _productServices.CreateProduct(productCreationDTO);
                return CreatedAtRoute("CreateProduct", response);
            }

            /// <summary>
            ///  Edit a product
            /// </summary>
            /// <param name="id"></param>
            /// /// <param name="patchDocument"></param>
            /// <returns></returns>
            [HttpPatch("{id}")]
            [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
            public async Task<ActionResult<ProductDTO>> PatchProduct(
                [FromRoute] string id,
                [FromBody] JsonPatchDocument<ProductPatchDTO> patchDocument)
            {
                if (patchDocument == null)
                {
                    return BadRequest("ProductPatchDocument doesn´t exists");
                }

                var response = await _productServices.PatchProduct(id, patchDocument, ModelState);

                if (response == null) return NotFound("Product not found");

                return response;
            }

            /// <summary>
            ///  Delete a product
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            [HttpDelete("{id}")]
            [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = $"{Roles.ADMIN}")]
            public async Task<ActionResult<ProductDTO>> DeleteProduct([FromRoute] string id)
            {
                var response = await _productServices.DeleteProduct(id);

                if (response == null) return NotFound("Product not found");

                return response;
            }
        }
}
