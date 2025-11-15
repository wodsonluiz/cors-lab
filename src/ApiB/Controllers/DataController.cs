using System;
using Microsoft.AspNetCore.Mvc;

namespace ApiB.Controllers
{
    [ApiController]
    [Route("data")]
    public class DataController: ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var response = new { Message = "Api B response with success", Time = DateTime.UtcNow};
            return Ok(response);
        }
    }
}