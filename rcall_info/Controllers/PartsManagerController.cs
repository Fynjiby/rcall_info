using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using fpv_info.Models;
using Microsoft.Extensions.Localization;
using Microsoft.EntityFrameworkCore;
using fpv_info.Models.ManagerModels;
using Microsoft.AspNetCore.Authorization;

namespace fpv_info.Controllers
{
    [Authorize(Roles = "ContentAdmin")]
    public class PartsManagerController : Controller
    {

        private PartsContext PartsContext;
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;
        public PartsManagerController(PartsContext context, IStringLocalizer<SharedResource> sharedLocalizer)
        {
            PartsContext = context;
            _sharedLocalizer = sharedLocalizer;
        }

        public IActionResult Index()
        {
            Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("FC_list", _sharedLocalizer[SharedResource.GetNameRes("fc")]);
            items.Add("PDB_list", "PDB");
            items.Add("Accessories_list", _sharedLocalizer[SharedResource.GetNameRes("accessories")]);
            items.Add("Light_list", _sharedLocalizer[SharedResource.GetNameRes("light")]);
            items.Add("Motors_list", _sharedLocalizer[SharedResource.GetNameRes("motors")]);
            items.Add("ESC_list", "ESC");
            items.Add("Props_list", _sharedLocalizer[SharedResource.GetNameRes("props")]);
            items.Add("Servos_list", _sharedLocalizer[SharedResource.GetNameRes("servos")]);
            items.Add("Videotransmitters_list", _sharedLocalizer[SharedResource.GetNameRes("videotransmitters")]);
            items.Add("Videoreceivers_list", _sharedLocalizer[SharedResource.GetNameRes("videoreceivers")]);
            items.Add("Cameras_list", _sharedLocalizer[SharedResource.GetNameRes("cameras")]);
            items.Add("Goggles_list", _sharedLocalizer[SharedResource.GetNameRes("goggles")]);
            items.Add("Antennas_list", _sharedLocalizer[SharedResource.GetNameRes("antennas")]);
            items.Add("Transmitters_list", _sharedLocalizer[SharedResource.GetNameRes("transmitters")]);
            items.Add("Receivers_list", _sharedLocalizer[SharedResource.GetNameRes("receivers")]);
            items.Add("Rcother_list", _sharedLocalizer[SharedResource.GetNameRes("rcother")]);
            items.Add("Batteries_list", _sharedLocalizer[SharedResource.GetNameRes("batteries")]);
            items.Add("Chargers_list", _sharedLocalizer[SharedResource.GetNameRes("chargers")]);
            items.Add("Frames_list", _sharedLocalizer[SharedResource.GetNameRes("frames")]);
            items.Add("Body_list", _sharedLocalizer[SharedResource.GetNameRes("body")]);

            return View(items);
        }

        #region Lists

        public async Task<IActionResult> FC_list(int page = 1)
        {
            IQueryable<Part> source = PartsContext.FlightControllers;
            ListPartsManagerViewModel viewModel = await Parts_list(page, source, "FC_list");
            return View("Part_list", viewModel);
        }

        public async Task<IActionResult> PDB_list(int page = 1)
        {
            IQueryable<Part> source = PartsContext.PDBs;
            ListPartsManagerViewModel viewModel = await Parts_list(page, source, "PDB_list");
            return View("Part_list", viewModel);
        }

        public async Task<IActionResult> Accessories_list(int page = 1)
        {
            IQueryable<Part> source = PartsContext.Accessories;
            ListPartsManagerViewModel viewModel = await Parts_list(page, source, "Accessories_list");
            return View("Part_list", viewModel);
        }

        public async Task<IActionResult> Light_list(int page = 1)
        {
            IQueryable<Part> source = PartsContext.Lights;
            ListPartsManagerViewModel viewModel = await Parts_list(page, source, "Light_list");
            return View("Part_list", viewModel);
        }

        public async Task<IActionResult> Motors_list(int page = 1)
        {
            IQueryable<Part> source = PartsContext.Motors;
            ListPartsManagerViewModel viewModel = await Parts_list(page, source, "Motors_list");
            return View("Part_list", viewModel);
        }

        public async Task<IActionResult> ESC_list(int page = 1)
        {
            IQueryable<Part> source = PartsContext.ESCs;
            ListPartsManagerViewModel viewModel = await Parts_list(page, source, "ESC_list");
            return View("Part_list", viewModel);
        }

        public async Task<IActionResult> Props_list(int page = 1)
        {
            IQueryable<Part> source = PartsContext.Props;
            ListPartsManagerViewModel viewModel = await Parts_list(page, source, "Props_list");
            return View("Part_list", viewModel);
        }

        public async Task<IActionResult> Servos_list(int page = 1)
        {
            IQueryable<Part> source = PartsContext.Servos;
            ListPartsManagerViewModel viewModel = await Parts_list(page, source, "Servos_list");
            return View("Part_list", viewModel);
        }

        public async Task<IActionResult> Videotransmitters_list(int page = 1)
        {
            IQueryable<Part> source = PartsContext.VideoTransmitters;
            ListPartsManagerViewModel viewModel = await Parts_list(page, source, "Videotransmitters_list");
            return View("Part_list", viewModel);
        }

        public async Task<IActionResult> Videoreceivers_list(int page = 1)
        {
            IQueryable<Part> source = PartsContext.VideoReceivers;
            ListPartsManagerViewModel viewModel = await Parts_list(page, source, "Videoreceivers_list");
            return View("Part_list", viewModel);
        }

        public async Task<IActionResult> Cameras_list(int page = 1)
        {
            IQueryable<Part> source = PartsContext.Cameras;
            ListPartsManagerViewModel viewModel = await Parts_list(page, source, "Cameras_list");
            return View("Part_list", viewModel);
        }

        public async Task<IActionResult> Goggles_list(int page = 1)
        {
            IQueryable<Part> source = PartsContext.FlightControllers;
            ListPartsManagerViewModel viewModel = await Parts_list(page, source, "Goggles_list");
            return View("Part_list", viewModel);
        }

        public async Task<IActionResult> Antennas_list(int page = 1)
        {
            IQueryable<Part> source = PartsContext.Antennas;
            ListPartsManagerViewModel viewModel = await Parts_list(page, source, "Antennas_list");
            return View("Part_list", viewModel);
        }

        public async Task<IActionResult> Transmitters_list(int page = 1)
        {
            IQueryable<Part> source = PartsContext.Transmitters;
            ListPartsManagerViewModel viewModel = await Parts_list(page, source, "Transmitters_list");
            return View("Part_list", viewModel);
        }

        public async Task<IActionResult> Receivers_list(int page = 1)
        {
            IQueryable<Part> source = PartsContext.Receivers;
            ListPartsManagerViewModel viewModel = await Parts_list(page, source, "Receivers_list");
            return View("Part_list", viewModel);
        }

        public async Task<IActionResult> Rcother_list(int page = 1)
        {
            IQueryable<Part> source = PartsContext.RCOthers;
            ListPartsManagerViewModel viewModel = await Parts_list(page, source, "Rcother_list");
            return View("Part_list", viewModel);
        }

        public async Task<IActionResult> Batteries_list(int page = 1)
        {
            IQueryable<Part> source = PartsContext.Batteries;
            ListPartsManagerViewModel viewModel = await Parts_list(page, source, "Batteries_list");
            return View("Part_list", viewModel);
        }

        public async Task<IActionResult> Chargers_list(int page = 1)
        {
            IQueryable<Part> source = PartsContext.Chargers;
            ListPartsManagerViewModel viewModel = await Parts_list(page, source, "Chargers_list");
            return View("Part_list", viewModel);
        }

        public async Task<IActionResult> Frames_list(int page = 1)
        {
            IQueryable<Part> source = PartsContext.Frames;
            ListPartsManagerViewModel viewModel = await Parts_list(page, source, "Frames_list");
            return View("Part_list", viewModel);
        }

        public async Task<IActionResult> Body_list(int page = 1)
        {
            IQueryable<Part> source = PartsContext.Fuselages;
            ListPartsManagerViewModel viewModel = await Parts_list(page, source, "Body_list");
            return View("Part_list", viewModel);
        }

        private async Task<ListPartsManagerViewModel> Parts_list(int page, IQueryable<Part> source, string caller)
        {
            ViewData["add"] = _sharedLocalizer[SharedResource.GetNameRes("add")];
            ViewData["nameEn"] = _sharedLocalizer[SharedResource.GetNameRes("nameEn")];
            ViewData["nameRu"] = _sharedLocalizer[SharedResource.GetNameRes("nameRu")];
            ViewData["details"] = _sharedLocalizer[SharedResource.GetNameRes("details")];
            ViewData["edit"] = _sharedLocalizer[SharedResource.GetNameRes("edit")];
            ViewData["delete"] = _sharedLocalizer[SharedResource.GetNameRes("delete")];
            ViewData["back"] = _sharedLocalizer[SharedResource.GetNameRes("back")];
            ViewData["next"] = _sharedLocalizer[SharedResource.GetNameRes("next")];
            ViewData["caller"] = caller;
            ViewData["methodCreate"] = "CreateFrom" + caller;
            ViewData["methodDetails"] = "DetailsFrom" + caller;
            ViewData["methodEdit"] = "EditFrom" + caller;
            ViewData["methodDelete"] = "DeleteFrom" + caller;

            int pageSize = 20;

            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            ListPartsManagerViewModel viewModel = new ListPartsManagerViewModel
            {
                PageViewModel = pageViewModel,
                Parts = items
            };
            return viewModel;
        }

        #endregion

        //public IActionResult CreateFromFC_list()
        //{
        //    ViewData["add"] = _sharedLocalizer[SharedResource.GetNameRes("add")];
        //    ViewData["date"] = _sharedLocalizer[SharedResource.GetNameRes("date")];
        //    ViewData["titleEn"] = _sharedLocalizer[SharedResource.GetNameRes("titleEn")];
        //    ViewData["titleRu"] = _sharedLocalizer[SharedResource.GetNameRes("titleRu")];
        //    ViewData["descriptionEn"] = _sharedLocalizer[SharedResource.GetNameRes("descriptionEn")];
        //    ViewData["descriptionRu"] = _sharedLocalizer[SharedResource.GetNameRes("descriptionEn")];
        //    ViewData["eventType"] = _sharedLocalizer[SharedResource.GetNameRes("eventType")];
        //    List<EventType> event_types = EventsContext.EventTypes.ToList();
        //    Event new_event = new Event
        //    {
        //        EventDate = DateTime.Now
        //    };

        //    EventsManagerModel viewModel = new EventsManagerModel
        //    {
        //        Event = new_event,
        //        EventTypes = new SelectList(event_types, "Id", "Name")
        //    };

        //    return View(viewModel);
        //}
        //[HttpPost]
        //public async Task<IActionResult> Create(EventsManagerModel new_event)
        //{
        //    Event event_to_add = new_event.Event;
        //    EventType find_type = await EventsContext.EventTypes.FirstOrDefaultAsync(p => p.Id == new_event.EventTypes_id);
        //    event_to_add.Type = find_type;
        //    EventsContext.Events.Add(event_to_add);
        //    await EventsContext.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}


    }
}
