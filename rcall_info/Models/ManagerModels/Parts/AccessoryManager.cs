using Microsoft.AspNetCore.Mvc.Rendering;


namespace fpv_info.Models.ManagerModels.Parts
{
    public class AccessoryManager : PartManager
    {
        public AccessoryModel Accessory { get; set; }
        public SelectList Type { get; set; }
        public int Type_id { get; set; }
    }
}
