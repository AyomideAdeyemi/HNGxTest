using HNGxTest.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace YourApiName.Controllers
{
    [Route("api")]
    [ApiController]
    public class StageOneController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get([FromQuery] RequestInput requestInput)
        {
            var data = new ResponseModel()
            {
                Slack_name = requestInput.Slack_name,
                Track = requestInput.Track
            };
            return Ok(data);
        }


    }
}
