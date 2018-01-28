
using System;

namespace fpv_info.Models
{
    public class Event
    {
        public int Id { get; set; }
        public EventType Type { get; set; }
        public DateTime EventDate { get; set; }
        public string Title_en { get; set; }
        public string Title_ru { get; set; }
        public string Description_en { get; set; }
        public string Description_ru { get; set; }
    }
}
