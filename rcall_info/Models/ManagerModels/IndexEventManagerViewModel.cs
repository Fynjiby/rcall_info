
using System.Collections.Generic;


namespace fpv_info.Models.ManagerModels
{
    public class IndexEventManagerViewModel
    {
        public IEnumerable<Event> Events { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
