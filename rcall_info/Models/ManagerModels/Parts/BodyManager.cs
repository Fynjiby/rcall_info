using Microsoft.AspNetCore.Mvc.Rendering;


namespace fpv_info.Models.ManagerModels.Parts
{
    public class BodyManager : PartManager
    {
        public Fuselage Fuselage { get; set; }
        public SelectList Type { get; set; }
        public int Type_id { get; set; }
        public SelectList Materials { get; set; }
        public int Material_id { get; set; }
    }
}
