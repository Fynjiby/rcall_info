using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace fpv_info.Models.ManagerModels
{
    public class EventsManagerModel
    {
        public Event Event { get; set; }
        public SelectList EventTypes { get; set; }
        public int EventTypes_id { get; set; }
    }
}
