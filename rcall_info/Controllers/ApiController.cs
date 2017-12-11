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
        [Route("start")]
        [HttpGet]
        public IActionResult Start()
        {
            List<ItemMenu> itemsMenu = new List<ItemMenu>
            {
                new ItemMenu("copters","Мультикоптеры","/images/quad.svg"),
                new ItemMenu("plane","Самолеты","/images/plane.svg")
            };
            return Json(new
            {
                itemsMenu
            });
        }

        [Route("copters")]
        [HttpGet]
        public IActionResult Copters()
        {
            List<ItemMenu> MotorsItems = new List<ItemMenu>
            {
                new ItemMenu("../copters/parts/motors","Моторы","/images/quad.svg"),
                new ItemMenu("../copters/parts/esc","ESC","/images/quad.svg")
            };
            List<ItemMenu> ComponentItems = new List<ItemMenu>
            {
                new ItemMenu("../copters/parts/flams","Рамы","/images/quad.svg"),
                new ItemMenu("","ВМГ","","fa-superpowers",MotorsItems)
            };
            List<ItemMenu> itemsMenu = new List<ItemMenu>
            {
                new ItemMenu("../copters/events","События","/images/plane.svg"),
                new ItemMenu("../copters/parts","Комплектующие","/images/plane.svg","",ComponentItems)
            };
            return Json(new
            {
                itemsMenu
            });
        }

        [Route("plane")]
        [HttpGet]
        public IActionResult Plane()
        {
            List<ItemMenu> childItems = new List<ItemMenu>
            {
                new ItemMenu("../plane/parts/motors","Моторы","/images/quad.svg"),
                new ItemMenu("../plane/parts/flams","Рамы","/images/quad.svg"),
                new ItemMenu("../plane/parts/esc","ESC","/images/quad.svg")
            };
            List<ItemMenu> itemsMenu = new List<ItemMenu>
            {
                new ItemMenu("../plane/news","Новости","/images/quad.svg"),
                new ItemMenu("../plane/events","События","/images/plane.svg"),
                new ItemMenu("","Комплектующие","/images/plane.svg", "",childItems)
            };
            return Json(new
            {
                itemsMenu
            });
        }

        private struct ItemMenu
        {
            public string text;
            public string image;
            public string icon;
            public string link;
            public List<ItemMenu> childItems;
            public bool haveChild;
            public bool isImage;
            public bool open;

            public ItemMenu(string lnk, string txt, string img, string ico = "", List<ItemMenu> child = null)
            {
                link = lnk;
                text = txt;
                image = img;
                icon = ico;
                childItems = child;
                haveChild = child != null;
                isImage = image != "";
                open = false;
            }
        }
    }
}
