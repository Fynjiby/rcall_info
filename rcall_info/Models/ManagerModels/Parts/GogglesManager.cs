using Microsoft.AspNetCore.Mvc.Rendering;


namespace fpv_info.Models.ManagerModels.Parts
{
    public class GogglesManager : PartManager
    {
        public Goggle Goggle { get; set; }
        public SelectList FOVs { get; set; }
        public int FOV_id { get; set; }
        public SelectList Displays { get; set; }
        public int Display_id { get; set; }
        public SelectList AspectsRatio { get; set; }
        public int AspectRatio_id { get; set; }
    }
}
