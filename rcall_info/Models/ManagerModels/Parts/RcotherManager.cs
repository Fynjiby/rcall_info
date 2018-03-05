using Microsoft.AspNetCore.Mvc.Rendering;


namespace fpv_info.Models.ManagerModels.Parts
{
    public class RcotherManager : PartManager
    {
        public RCOther Rcother { get; set; }
        public SelectList Type { get; set; }
        public int Type_id { get; set; }
    }
}
