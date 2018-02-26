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
            IQueryable<Part> source = PartsContext.Goggles;
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
            ViewData["methodDelete"] = "Delete" + caller;

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

        #region Create

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

        #endregion

        #region Edit

        #endregion

        #region Delete

        [HttpGet]
        [ActionName("DeleteFC_list")]
        public async Task<IActionResult> ConfirmDeleteFromFC_list(int? id)
        {
            if (id != null)
            {
                FlightController find_part = await PartsContext.FlightControllers.FirstOrDefaultAsync(p => p.Id == id);
                return DeleteView(find_part, "FC_list");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteFC_list(int? id)
        {
            if (id != null)
            {
                FlightController find_part = new FlightController { Id = id.Value };
                await DeletePart(find_part);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("DeletePDB_list")]
        public async Task<IActionResult> ConfirmDeleteFromPDB_list(int? id)
        {
            if (id != null)
            {
                PDB find_part = await PartsContext.PDBs.FirstOrDefaultAsync(p => p.Id == id);
                return DeleteView(find_part, "PDB_list");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeletePDB_list(int? id)
        {
            if (id != null)
            {
                PDB find_part = new PDB { Id = id.Value };
                await DeletePart(find_part);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("DeleteAccessories_list")]
        public async Task<IActionResult> ConfirmDeleteFromAccessories_list(int? id)
        {
            if (id != null)
            {
                AccessoryModel find_part = await PartsContext.Accessories.FirstOrDefaultAsync(p => p.Id == id);
                return DeleteView(find_part, "Accessories_list");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAccessories_list(int? id)
        {
            if (id != null)
            {
                AccessoryModel find_part = new AccessoryModel { Id = id.Value };
                await DeletePart(find_part);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("DeleteLight_list")]
        public async Task<IActionResult> ConfirmDeleteFromLight_list(int? id)
        {
            if (id != null)
            {
                Light find_part = await PartsContext.Lights.FirstOrDefaultAsync(p => p.Id == id);
                return DeleteView(find_part, "Light_list");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteLight_list(int? id)
        {
            if (id != null)
            {
                Light find_part = new Light { Id = id.Value };
                await DeletePart(find_part);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("DeleteMotors_list")]
        public async Task<IActionResult> ConfirmDeleteFromMotors_list(int? id)
        {
            if (id != null)
            {
                Motor find_part = await PartsContext.Motors.FirstOrDefaultAsync(p => p.Id == id);
                return DeleteView(find_part, "Motors_list");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMotors_list(int? id)
        {
            if (id != null)
            {
                Motor find_part = new Motor { Id = id.Value };
                await DeletePart(find_part);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("DeleteESC_list")]
        public async Task<IActionResult> ConfirmDeleteFromESC_list(int? id)
        {
            if (id != null)
            {
                ESC find_part = await PartsContext.ESCs.FirstOrDefaultAsync(p => p.Id == id);
                return DeleteView(find_part, "ESC_list");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteESC_list(int? id)
        {
            if (id != null)
            {
                ESC find_part = new ESC { Id = id.Value };
                await DeletePart(find_part);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("DeleteProps_list")]
        public async Task<IActionResult> ConfirmDeleteFromProps_list(int? id)
        {
            if (id != null)
            {
                Prop find_part = await PartsContext.Props.FirstOrDefaultAsync(p => p.Id == id);
                return DeleteView(find_part, "Props_list");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProps_list(int? id)
        {
            if (id != null)
            {
                Prop find_part = new Prop { Id = id.Value };
                await DeletePart(find_part);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("DeleteServos_list")]
        public async Task<IActionResult> ConfirmDeleteFromServos_list(int? id)
        {
            if (id != null)
            {
                Servo find_part = await PartsContext.Servos.FirstOrDefaultAsync(p => p.Id == id);
                return DeleteView(find_part, "Servos_list");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteServos_list(int? id)
        {
            if (id != null)
            {
                Servo find_part = new Servo { Id = id.Value };
                await DeletePart(find_part);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("DeleteVideotransmitters_list")]
        public async Task<IActionResult> ConfirmDeleteFromVideotransmitters_list(int? id)
        {
            if (id != null)
            {
                VideoTransmitter find_part = await PartsContext.VideoTransmitters.FirstOrDefaultAsync(p => p.Id == id);
                return DeleteView(find_part, "Videotransmitters_list");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteVideotransmitters_list(int? id)
        {
            if (id != null)
            {
                VideoTransmitter find_part = new VideoTransmitter { Id = id.Value };
                await DeletePart(find_part);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("DeleteVideoreceivers_list")]
        public async Task<IActionResult> ConfirmDeleteFromVideoreceivers_list(int? id)
        {
            if (id != null)
            {
                VideoReceiver find_part = await PartsContext.VideoReceivers.FirstOrDefaultAsync(p => p.Id == id);
                return DeleteView(find_part, "Videoreceivers_list");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteVideoreceivers_list(int? id)
        {
            if (id != null)
            {
                VideoReceiver find_part = new VideoReceiver { Id = id.Value };
                await DeletePart(find_part);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("DeleteCameras_list")]
        public async Task<IActionResult> ConfirmDeleteFromCameras_list(int? id)
        {
            if (id != null)
            {
                Camera find_part = await PartsContext.Cameras.FirstOrDefaultAsync(p => p.Id == id);
                return DeleteView(find_part, "Cameras_list");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCameras_list(int? id)
        {
            if (id != null)
            {
                Camera find_part = new Camera { Id = id.Value };
                await DeletePart(find_part);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("DeleteGoggles_list")]
        public async Task<IActionResult> ConfirmDeleteFromGoggles_list(int? id)
        {
            if (id != null)
            {
                Goggle find_part = await PartsContext.Goggles.FirstOrDefaultAsync(p => p.Id == id);
                return DeleteView(find_part, "Goggles_list");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteGoggles_list(int? id)
        {
            if (id != null)
            {
                Goggle find_part = new Goggle { Id = id.Value };
                await DeletePart(find_part);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("DeleteAntennas_list")]
        public async Task<IActionResult> ConfirmDeleteFromAntennas_list(int? id)
        {
            if (id != null)
            {
                Antenna find_part = await PartsContext.Antennas.FirstOrDefaultAsync(p => p.Id == id);
                return DeleteView(find_part, "Antennas_list");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAntennas_list(int? id)
        {
            if (id != null)
            {
                Antenna find_part = new Antenna { Id = id.Value };
                await DeletePart(find_part);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("DeleteTransmitters_list")]
        public async Task<IActionResult> ConfirmDeleteFromTransmitters_list(int? id)
        {
            if (id != null)
            {
                Transmitter find_part = await PartsContext.Transmitters.FirstOrDefaultAsync(p => p.Id == id);
                return DeleteView(find_part, "Transmitters_list");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteTransmitters_list(int? id)
        {
            if (id != null)
            {
                Transmitter find_part = new Transmitter { Id = id.Value };
                await DeletePart(find_part);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("DeleteReceivers_list")]
        public async Task<IActionResult> ConfirmDeleteFromReceivers_list(int? id)
        {
            if (id != null)
            {
                Receiver find_part = await PartsContext.Receivers.FirstOrDefaultAsync(p => p.Id == id);
                return DeleteView(find_part, "Receivers_list");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteReceivers_list(int? id)
        {
            if (id != null)
            {
                Receiver find_part = new Receiver { Id = id.Value };
                await DeletePart(find_part);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("DeleteRcother_list")]
        public async Task<IActionResult> ConfirmDeleteFromRcother_list(int? id)
        {
            if (id != null)
            {
                RCOther find_part = await PartsContext.RCOthers.FirstOrDefaultAsync(p => p.Id == id);
                return DeleteView(find_part, "Rcother_list");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteRcother_list(int? id)
        {
            if (id != null)
            {
                RCOther find_part = new RCOther { Id = id.Value };
                await DeletePart(find_part);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("DeleteBatteries_list")]
        public async Task<IActionResult> ConfirmDeleteFromBatteries_list(int? id)
        {
            if (id != null)
            {
                Battery find_part = await PartsContext.Batteries.FirstOrDefaultAsync(p => p.Id == id);
                return DeleteView(find_part, "Batteries_list");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteBatteries_list(int? id)
        {
            if (id != null)
            {
                Battery find_part = new Battery { Id = id.Value };
                await DeletePart(find_part);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("DeleteChargers_list")]
        public async Task<IActionResult> ConfirmDeleteFromChargers_list(int? id)
        {
            if (id != null)
            {
                Charger find_part = await PartsContext.Chargers.FirstOrDefaultAsync(p => p.Id == id);
                return DeleteView(find_part, "Chargers_list");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteChargers_list(int? id)
        {
            if (id != null)
            {
                Charger find_part = new Charger { Id = id.Value };
                await DeletePart(find_part);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("DeleteFrames_list")]
        public async Task<IActionResult> ConfirmDeleteFromFrames_list(int? id)
        {
            if (id != null)
            {
                Frame find_part = await PartsContext.Frames.FirstOrDefaultAsync(p => p.Id == id);
                return DeleteView(find_part, "Frames_list");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteFrames_list(int? id)
        {
            if (id != null)
            {
                Frame find_part = new Frame { Id = id.Value };
                await DeletePart(find_part);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("DeleteBody_list")]
        public async Task<IActionResult> ConfirmDeleteFromBody_list(int? id)
        {
            if (id != null)
            {
                Fuselage find_part = await PartsContext.Fuselages.FirstOrDefaultAsync(p => p.Id == id);
                return DeleteView(find_part, "Body_list");
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteBody_list(int? id)
        {
            if (id != null)
            {
                Fuselage find_part = new Fuselage { Id = id.Value };
                await DeletePart(find_part);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        private IActionResult DeleteView(Part part, string caller)
        {
            ViewData["methodDeletePost"] = "Delete" + caller;
            return View("Delete", part);
        }

        private async Task DeletePart(Part part)
        {
            PartsContext.Entry(part).State = EntityState.Deleted;
            await PartsContext.SaveChangesAsync();
        }

        #endregion

    }
}
