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
            List<ItemMenu> ElectronicsItems = new List<ItemMenu>
            {
                new ItemMenu("/copters/parts/fc","Контроллеры","","fa-microchip"),
                new ItemMenu("/copters/parts/pdb","PDB","","fa-bolt"),
                new ItemMenu("/copters/parts/other","Периферия","","fa-compass"),
                new ItemMenu("/copters/parts/light","Свет","","fa-lightbulb-o")
            };

            List<ItemMenu> MotorsItems = new List<ItemMenu>
            {
                new ItemMenu("/copters/parts/motors","Моторы","/images/motor.png"),
                new ItemMenu("/copters/parts/esc","ESC","","fa-microchip"),
                new ItemMenu("/copters/parts/props","Пропеллеры","/images/prop.svg")
            };

            List<ItemMenu> FPVItems = new List<ItemMenu>
            {
                new ItemMenu("/copters/parts/videoreceivers","Приемники","","fa-rss"),
                new ItemMenu("/copters/parts/videotransmitters","Передатчики","","fa-podcast"),
                new ItemMenu("/copters/parts/cameras","Камеры","","fa-video-camera"),
                new ItemMenu("/copters/parts/goggles","Очки, шлемы","/images/goggles.svg"),
                new ItemMenu("/copters/parts/antennas","Антенны","/images/antenna.svg")
            };

            List<ItemMenu> RCItems = new List<ItemMenu>
            {
                new ItemMenu("/copters/parts/transmitters","Передатчики","/images/rctransmitter.svg"),
                new ItemMenu("/copters/parts/receivers","Приемники","","fa-rss"),
                new ItemMenu("/copters/parts/rcother","Прочее","","fa-dot-circle-o")
            };

            List<ItemMenu> BatteryItems = new List<ItemMenu>
            {
                new ItemMenu("/copters/parts/battery","Аккумуляторы","","fa-battery-three-quarters"),
                new ItemMenu("/copters/parts/charger","Зарядные","","fa-bolt")
            };

            List<ItemMenu> ComponentItems = new List<ItemMenu>
            {
                new ItemMenu("/copters/parts/flams","Рамы","/images/quad.svg"),
                new ItemMenu("","Электроника","","fa-microchip",ElectronicsItems),
                new ItemMenu("","ВМГ","","fa-superpowers",MotorsItems),                
                new ItemMenu("","Радио управление","","fa-wifi",RCItems),
                new ItemMenu("","FPV","","fa-podcast",FPVItems),
                new ItemMenu("","Аккумуляторы","","fa-battery-full",BatteryItems)
            };
            List<ItemMenu> itemsMenu = new List<ItemMenu>
            {
                new ItemMenu("/copters/events","События","","fa-calendar"),
                new ItemMenu("","Комплектующие","","fa-cogs",ComponentItems,true)
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

            public ItemMenu(string lnk, string txt, string img, string ico = "", List<ItemMenu> child = null, bool firstLevel = false)
            {
                link = lnk;
                text = txt;
                image = img;
                icon = ico;
                childItems = child;
                haveChild = child != null;
                isImage = image != "";
                open = firstLevel;
            }
        }
    }
}
