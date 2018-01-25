using System.Collections.Generic;

namespace fpv_info.Models
{
    public class Goggle : Part
    {
        public FOV FOV { get; set; }
        public string IPD { get; set; }
        public Display Display { get; set; }
        public AspectRatio AspectRatio { get; set; }
        public bool DVR { get; set; }
    }
}
