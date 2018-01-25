using System.Collections.Generic;

namespace fpv_info.Models
{
    public class Frame : Part
    {
        public FrameType Type { get; set; }
        public InstallDimension InstallDimensionProc { get; set; }
        public InstallDimensionMotor InstallDimensionMotor { get; set; }
        public Material Material { get; set; }
        public int Wheelbase { get; set; }
    }
}
