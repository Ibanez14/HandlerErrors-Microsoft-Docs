using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExceptionHandler.Controllers
{
    [Route("Error")]
    public class ErrorController : Controller
    {
        [Route("")]
        // GET: /<controller>/
        public IActionResult Index()
        {

            string ExceptionMessage = string.Empty;

            var exceptionHandlerPathFeature =
                HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            if(exceptionHandlerPathFeature.Error is ArgumentException)
            {
                ExceptionMessage = "Argument Null Exception is thrown \n";
                // Some logging
            }
            if(exceptionHandlerPathFeature.Path == "/api/valuess")
            {
                ExceptionMessage += "Thrown in API Values Controller \n";
                // another logging
            }






            //return Content("Something went wrong");
            return View();
        }
    }
}
