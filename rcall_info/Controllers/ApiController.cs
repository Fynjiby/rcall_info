using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rcall_info.Controllers
{
    [Route("api")]
    public class ApiController : Controller
    {
		[Route("hello")]
		[HttpGet]
		public IActionResult Hello()
		{
			var msg = new { Message = "Hello World" };
			return this.Ok(msg);
		}
    }
}
