using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rcall_info.Controllers
{
    public class StartController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetData()
        {
            List<Item> items = new List<Item>
            {
                new Item("adin"),
                new Item("dva"),
                new Item("tri")
            };
            return Json(new
            {
                items
            });
        }
         private struct Item
        {
            public string text;
            public Item(string txt)
            {
                text = txt;
            }
        }
    }

}
