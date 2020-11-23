using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quete_Routage.Controllers
{
    public class HelloConvController
    {
        //Routage par convention
        public String Say()
        {
            return "Hello !";
        }

        public String Yell()
        {
            return "HELLO !";
        }
    }
}
