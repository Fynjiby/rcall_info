using Microsoft.AspNetCore.Mvc.Rendering;


namespace fpv_info.Models.ManagerModels.Parts
{
    public class FramesManager : PartManager
    {
        public Frame Frame { get; set; }
        public SelectList Type { get; set; }
        public int Type_id { get; set; }
        public SelectList InstallDimensionsProc { get; set; }
        public int InstallDimensionProc_id { get; set; }
        public SelectList InstallDimensionsMotor { get; set; }
        public int InstallDimensionMotor_id { get; set; }
        public SelectList Materials { get; set; }
        public int Material_id { get; set; }
    }
}
