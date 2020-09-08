using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Visionist.Portal.wwwroot.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(string language="en")
        {
            string content = System.IO.File.ReadAllText("./wwwroot/Index.html");
            return base.Content(content, new MediaTypeHeaderValue("text/html"));

        }
    }
}
