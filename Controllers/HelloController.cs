using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quete_Routage.Controllers
{
    //Routage par attribut avec endpoints.MapControllers()
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        [Route("sayhello")]
        public String SayHello()
        {
            return "Hello !";
        }

        [HttpGet]
        [Route("yellhello")]
        public String YellHello()
        {
            return "HELLO !";
        }
    }
}
