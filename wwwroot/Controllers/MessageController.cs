using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Visionist.Portal.wwwroot.Controllers
{
    public class MessageController : Controller
    {
        // GET: /<controller>/
        [HttpPost]
        public IActionResult Send([FromBody] models.Message message)
        {            
            var sessionInfo = JsonConvert.SerializeObject(Request.Headers);
            //Data.Portal.SaveMessage(sessionInfo, message.name, message.email, message.phone, message.message);
            EmailHelper.Send(message.name, message.email, message.phone, message.message);
            return Ok();
        }
    }
}
