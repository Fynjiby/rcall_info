using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rcall_info.Controllers
{
    [Route("api")]
    public class ApiController : Controller
    {
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;

        public ApiController(IStringLocalizer<SharedResource> sharedLocalizer)
        {
            _sharedLocalizer = sharedLocalizer;
        }

        [Route("start")]
        [HttpGet]
        public IActionResult Start()
        {
            List<ItemMenu> ElectronicsItems = new List<ItemMenu>
            {
                new ItemMenu("/parts/fc",_sharedLocalizer[SharedResource.GetNameRes("fc")],"","fa-microchip"),
                new ItemMenu("/parts/pdb","PDB","","fa-bolt"),
                new ItemMenu("/parts/other","Периферия","","fa-compass"),
                new ItemMenu("/parts/light","Свет","","fa-lightbulb-o")
            };

            List<ItemMenu> MotorsItems = new List<ItemMenu>
            {
                new ItemMenu("/parts/motors","Моторы","/images/motor.png"),
                new ItemMenu("/parts/esc","ESC","","fa-microchip"),
                new ItemMenu("/parts/props","Пропеллеры","/images/prop.svg"),
                new ItemMenu("/parts/servos","Сервоприводы","","fa-cogs")
            };

            List<ItemMenu> FPVItems = new List<ItemMenu>
            {
                new ItemMenu("/parts/videoreceivers","Приемники","","fa-rss"),
                new ItemMenu("/parts/videotransmitters","Передатчики","","fa-podcast"),
                new ItemMenu("/parts/cameras","Камеры","","fa-video-camera"),
                new ItemMenu("/parts/goggles","Очки, шлемы","/images/goggles.svg"),
                new ItemMenu("/parts/antennas","Антенны","/images/antenna.svg")
            };

            List<ItemMenu> RCItems = new List<ItemMenu>
            {
                new ItemMenu("/parts/transmitters","Передатчики","/images/rctransmitter.svg"),
                new ItemMenu("/parts/receivers","Приемники","","fa-rss"),
                new ItemMenu("/parts/rcother","Прочее","","fa-dot-circle-o")
            };

            List<ItemMenu> BatteryItems = new List<ItemMenu>
            {
                new ItemMenu("/parts/battery","Аккумуляторы","","fa-battery-three-quarters"),
                new ItemMenu("/parts/charger","Зарядные","","fa-bolt")
            };

            List<ItemMenu> ComponentItems = new List<ItemMenu>
            {
                new ItemMenu("/parts/flams","Рамы","/images/quad.svg"),
                new ItemMenu("/parts/body","Фюзеляж","/images/plane.svg"),
                new ItemMenu("","Электроника","","fa-microchip",ElectronicsItems),
                new ItemMenu("","ВМГ","","fa-superpowers",MotorsItems),
                new ItemMenu("","Радио управление","","fa-wifi",RCItems),
                new ItemMenu("","FPV","","fa-podcast",FPVItems),
                new ItemMenu("","Аккумуляторы","","fa-battery-full",BatteryItems)
            };
            List<ItemMenu> itemsMenu = new List<ItemMenu>
            {
                new ItemMenu("/events","События","","fa-calendar"),
                new ItemMenu("","Комплектующие","","fa-cogs",ComponentItems,true)
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
