//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace HNGxTest.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class HNGxTestController : ControllerBase
//    {
//        // GET: api/<ValuesController>
//        [HttpGet]
//        public IEnumerable<string> Get()
//        {
//            return new string[] { "value1", "value2" };
//        }

//        // GET api/<ValuesController>/5
//        [HttpGet("{id}")]
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST api/<ValuesController>
//        [HttpPost]
//        public void Post([FromBody] string value)
//        {
//        }

//        // PUT api/<ValuesController>/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        // DELETE api/<ValuesController>/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
//}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace YourApiName.Controllers
{
    [Route("api")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        [HttpGet]
        public ActionResult<object> Get(string slack_name, string track)
        {
            // Get the current day of the week
            string currentDay = DateTime.Now.ToString("dddd");

            // Get the current UTC time
            string currentUtcTime = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");

            // Replace with your GitHub file and repository URLs
            string githubFileUrl = "https://github.com/your_username/your_repository/blob/main/your_file.cs";
            string githubRepoUrl = "https://github.com/AyomideAdeyemi/HNGxTest";

            // Create the response object
            var response = new
            {
                slack_name,
                current_day = currentDay,
                current_utc_time = currentUtcTime,
                track,
                github_file_url = githubFileUrl,
                github_repo_url = githubRepoUrl,
                status_code = "200"
            };

            return Ok(response);
        }
    }
}
