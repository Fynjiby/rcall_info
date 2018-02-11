using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.AspNetCore.Authorization;

namespace fpv_info.Controllers
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
                new ItemMenu("/parts/other",_sharedLocalizer[SharedResource.GetNameRes("accessories")],"","fa-compass"),
                new ItemMenu("/parts/light",_sharedLocalizer[SharedResource.GetNameRes("light")],"","fa-lightbulb-o")
            };

            List<ItemMenu> MotorsItems = new List<ItemMenu>
            {
                new ItemMenu("/parts/motors",_sharedLocalizer[SharedResource.GetNameRes("motors")],"/images/motor.png"),
                new ItemMenu("/parts/esc","ESC","","fa-microchip"),
                new ItemMenu("/parts/props",_sharedLocalizer[SharedResource.GetNameRes("props")],"/images/prop.svg"),
                new ItemMenu("/parts/servos",_sharedLocalizer[SharedResource.GetNameRes("servos")],"","fa-cogs")
            };

            List<ItemMenu> FPVItems = new List<ItemMenu>
            {
                new ItemMenu("/parts/videotransmitters",_sharedLocalizer[SharedResource.GetNameRes("videotransmitters")],"","fa-podcast"),
                new ItemMenu("/parts/videoreceivers",_sharedLocalizer[SharedResource.GetNameRes("videoreceivers")],"","fa-rss"),                
                new ItemMenu("/parts/cameras",_sharedLocalizer[SharedResource.GetNameRes("cameras")],"","fa-video-camera"),
                new ItemMenu("/parts/goggles",_sharedLocalizer[SharedResource.GetNameRes("goggles")],"/images/goggles.svg"),
                new ItemMenu("/parts/antennas",_sharedLocalizer[SharedResource.GetNameRes("antennas")],"/images/antenna.svg")
            };

            List<ItemMenu> RCItems = new List<ItemMenu>
            {
                new ItemMenu("/parts/transmitters",_sharedLocalizer[SharedResource.GetNameRes("transmitters")],"/images/rctransmitter.svg"),
                new ItemMenu("/parts/receivers",_sharedLocalizer[SharedResource.GetNameRes("receivers")],"","fa-rss"),
                new ItemMenu("/parts/rcother",_sharedLocalizer[SharedResource.GetNameRes("rcother")],"","fa-dot-circle-o")
            };

            List<ItemMenu> BatteryItems = new List<ItemMenu>
            {
                new ItemMenu("/parts/batteries",_sharedLocalizer[SharedResource.GetNameRes("batteries")],"","fa-battery-three-quarters"),
                new ItemMenu("/parts/chargers",_sharedLocalizer[SharedResource.GetNameRes("chargers")],"","fa-bolt")
            };

            List<ItemMenu> ComponentItems = new List<ItemMenu>
            {
                new ItemMenu("/parts/frames",_sharedLocalizer[SharedResource.GetNameRes("frames")],"/images/quad.svg"),
                new ItemMenu("/parts/body",_sharedLocalizer[SharedResource.GetNameRes("body")],"/images/plane.svg"),
                new ItemMenu("",_sharedLocalizer[SharedResource.GetNameRes("electronics")],"","fa-microchip",ElectronicsItems),
                new ItemMenu("",_sharedLocalizer[SharedResource.GetNameRes("motors_accessories")],"","fa-superpowers",MotorsItems),
                new ItemMenu("",_sharedLocalizer[SharedResource.GetNameRes("radiosystems")],"","fa-wifi",RCItems),
                new ItemMenu("","FPV","","fa-podcast",FPVItems),
                new ItemMenu("",_sharedLocalizer[SharedResource.GetNameRes("batteries_group")],"","fa-battery-full",BatteryItems)
            };
            List<ItemMenu> itemsMenu = new List<ItemMenu>
            {
                new ItemMenu("/events",_sharedLocalizer[SharedResource.GetNameRes("events")],"","fa-calendar"),
                new ItemMenu("",_sharedLocalizer[SharedResource.GetNameRes("parts")],"","fa-cogs",ComponentItems,true)
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
