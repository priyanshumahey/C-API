using System.Collections.Generic;
using HelloWorld.Data;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;


namespace HelloWorld.Controllers
{
    [Route("api")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly MockHelloWorldRepo _repository = new MockHelloWorldRepo();
        [HttpGet]
        public ActionResult <IEnumerable<Hello>> GetAll()
        {
            var HelloItems = _repository.GetAppCommands();
            return Ok(HelloItems);
        }

    }
}