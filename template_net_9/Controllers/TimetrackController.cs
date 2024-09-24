using template_net_9.DTOs.Timetrack;
using template_net_9.Services;
using Microsoft.AspNetCore.Mvc;
using template_net_9.Services;
using template_net_9.DTOs.Timetrack;


namespace template_net_9.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class TimetrackController : ControllerBase
    {
        private readonly TimetrackServices _timetrackServices;
 

        public TimetrackController(TimetrackServices timetrackServices)
        {
            this._timetrackServices = timetrackServices;
        }

        /// <summary>
        /// Get a list of timetrack items
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<TimetrackItemDTO>>> GetTimetrackItems()
        {
            return Ok(await _timetrackServices.GetTimetrackItems());
        }
    }
}
