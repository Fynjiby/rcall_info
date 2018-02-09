using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using fpv_info.Models;
using fpv_info.Models.ManagerModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Localization;

namespace fpv_info.Controllers
{
    public class EventsManagerController : Controller
    {

        private EventsContext EventsContext;
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;
        public EventsManagerController(EventsContext context, IStringLocalizer<SharedResource> sharedLocalizer)
        {
            EventsContext = context;
            _sharedLocalizer = sharedLocalizer;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            ViewData["add"] = _sharedLocalizer[SharedResource.GetNameRes("add")];
            ViewData["date"] = _sharedLocalizer[SharedResource.GetNameRes("date")];
            ViewData["titleEn"] = _sharedLocalizer[SharedResource.GetNameRes("titleEn")];
            ViewData["titleRu"] = _sharedLocalizer[SharedResource.GetNameRes("titleRu")];
            ViewData["details"] = _sharedLocalizer[SharedResource.GetNameRes("details")];
            ViewData["edit"] = _sharedLocalizer[SharedResource.GetNameRes("edit")];
            ViewData["delete"] = _sharedLocalizer[SharedResource.GetNameRes("delete")];
            
            int pageSize = 25;

            IQueryable<Event> source = EventsContext.Events;
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexEventManagerViewModel viewModel = new IndexEventManagerViewModel
            {
                PageViewModel = pageViewModel,
                Events = items
            };
            return View(viewModel);

        }
        public IActionResult Create()
        {
            ViewData["add"] = _sharedLocalizer[SharedResource.GetNameRes("add")];
            ViewData["date"] = _sharedLocalizer[SharedResource.GetNameRes("date")];
            ViewData["titleEn"] = _sharedLocalizer[SharedResource.GetNameRes("titleEn")];
            ViewData["titleRu"] = _sharedLocalizer[SharedResource.GetNameRes("titleRu")];
            ViewData["descriptionEn"] = _sharedLocalizer[SharedResource.GetNameRes("descriptionEn")];
            ViewData["descriptionRu"] = _sharedLocalizer[SharedResource.GetNameRes("descriptionEn")];
            ViewData["eventType"] = _sharedLocalizer[SharedResource.GetNameRes("eventType")];
            List<EventType> event_types = EventsContext.EventTypes.ToList();
            Event new_event = new Event
            {
                EventDate = DateTime.Now
            };

            EventsManagerModel viewModel = new EventsManagerModel
            {
                Event = new_event,
                EventTypes = new SelectList(event_types, "Id", "Name")
            };

            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Create(EventsManagerModel new_event)
        {
            Event event_to_add = new_event.Event;
            EventType find_type = await EventsContext.EventTypes.FirstOrDefaultAsync(p => p.Id == new_event.EventTypes_id);
            event_to_add.Type = find_type;
            EventsContext.Events.Add(event_to_add);
            await EventsContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            return await FindModelReturnToView(id);
        }



        public async Task<IActionResult> Edit(int? id)
        {
            Event find_event;
            if (id != null)
            {
                find_event = await EventsContext.Events.Include(e => e.Type).FirstOrDefaultAsync(p => p.Id == id);
                if (find_event == null)
                    return NotFound();
            }
            else
            {
                return NotFound();
            }


            ViewData["add"] = _sharedLocalizer[SharedResource.GetNameRes("add")];
            ViewData["date"] = _sharedLocalizer[SharedResource.GetNameRes("date")];
            ViewData["titleEn"] = _sharedLocalizer[SharedResource.GetNameRes("titleEn")];
            ViewData["titleRu"] = _sharedLocalizer[SharedResource.GetNameRes("titleRu")];
            ViewData["descriptionEn"] = _sharedLocalizer[SharedResource.GetNameRes("descriptionEn")];
            ViewData["descriptionRu"] = _sharedLocalizer[SharedResource.GetNameRes("descriptionEn")];
            ViewData["eventType"] = _sharedLocalizer[SharedResource.GetNameRes("eventType")];
            List<EventType> event_types = EventsContext.EventTypes.ToList();            
            EventsManagerModel viewModel = new EventsManagerModel
            {
                Event = find_event,
                EventTypes = new SelectList(event_types, "Id", "Name")
            };

            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EventsManagerModel edited_event)
        {
            Event event_to_update = edited_event.Event;
            EventType find_type = await EventsContext.EventTypes.FirstOrDefaultAsync(p => p.Id == edited_event.EventTypes_id);
            event_to_update.Type = find_type;
            EventsContext.Events.Update(event_to_update);
            await EventsContext.SaveChangesAsync();
            return RedirectToAction("Index");

        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            return await FindModelReturnToView(id);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Event find_event = new Event { Id = id.Value };
                EventsContext.Entry(find_event).State = EntityState.Deleted;
                await EventsContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        public IActionResult CreateType()
        {
            ViewData["name"] = _sharedLocalizer[SharedResource.GetNameRes("name")];
            ViewData["path"] = _sharedLocalizer[SharedResource.GetNameRes("path")];
            return View(new EventType());
        }
        [HttpPost]
        public async Task<IActionResult> CreateType(EventType new_type)
        {
            EventsContext.EventTypes.Add(new_type);
            await EventsContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        private async Task<IActionResult> FindModelReturnToView(int? id)
        {
            if (id != null)
            {
                Event find_event = await EventsContext.Events.Include(e => e.Type).FirstOrDefaultAsync(p => p.Id == id);
                if (find_event != null)
                    return View(find_event);
            }
            return NotFound();
        }

    }
}
