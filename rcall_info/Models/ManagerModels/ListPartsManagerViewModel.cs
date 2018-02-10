using System.Collections.Generic;

namespace fpv_info.Models.ManagerModels
{
    public class ListPartsManagerViewModel
    {
        public IEnumerable<Part> Parts { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
