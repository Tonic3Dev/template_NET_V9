using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using template_net_9.DTOs;
using template_net_9.Entities;
using template_net_9.Extensions;

namespace template_net_9.Services
{
    public class ProductServices
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public ProductServices(ApplicationDbContext context,
            IMapper mapper, IConfiguration configuration)
        {
            this._context = context;
            this._mapper = mapper;
            this._configuration = configuration;
        }

        public async Task<ListResponse<ProductDTO>> GetProducts(
            BaseFilter baseFilter)
        {
            var products = _context.Products
                .AsQueryable();

            return await products.FilterSortPaginate<Product, ProductDTO>(
                baseFilter, _mapper);
        }


        public async Task<ProductDTO> GetProductById(string id)
        {
            var product = await _context.Products
                .FirstOrDefaultAsync(p => p.Id.ToString() == id);

            if (product == null)
            {
                return null;
            }

            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<ProductDTO> CreateProduct(ProductCreationDTO productCreationDTO)
        {
            var product = _mapper.Map<Product>(productCreationDTO);

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            var productDTO = _mapper.Map<ProductDTO>(product);

            return productDTO;
        }

        public async Task<ProductDTO> PatchProduct(string id,
            JsonPatchDocument<ProductPatchDTO> patchDocument,
            ModelStateDictionary modelState)
        {

            var product = await _context.Products
                .FirstOrDefaultAsync(x => x.Id.ToString() == id);

            if (product == null)
            {
                return null;
            }


            var productPatchDTO = _mapper.Map<ProductPatchDTO>(product);

            patchDocument.ApplyTo(productPatchDTO, modelState);


            if (!modelState.IsValid)
            {
                throw new BadHttpRequestException("The modelstate is not valid");
            }

            _mapper.Map(productPatchDTO, product);

            await _context.SaveChangesAsync();
            var productDTO = _mapper.Map<ProductDTO>(product);
            return productDTO;
        }

        public async Task<ProductDTO> DeleteProduct(string id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id.ToString() == id);

            if (product == null)
            {
                return null;
            }

            _context.Remove(product);
            await _context.SaveChangesAsync();
            var productDTO = _mapper.Map<ProductDTO>(product);
            return productDTO;
        }
    }
}
