using System;
using Microsoft.AspNetCore.Mvc;
using NowWebApp.Models;

namespace NowWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateTimeController : ControllerBase
    {
        // GET api/datetime
        [HttpGet]
        public ActionResult Get()
        {
            var dateTime = new MyAppDateTime 
            { 
                NowForMe = DateTime.Now,
                Version = "1.0"
            }; 
            return Ok(dateTime);
        }
    }
}
