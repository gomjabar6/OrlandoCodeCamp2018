using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Code_Camp_Demo.Controllers
{
    public class ExceptionController : Controller
    {
        public IActionResult Index()
        {

            SuperCoolFunction();

           
            return View();
        }

        private void SuperCoolFunction()
        {
            throw new NotImplementedException();
        }
    }
}