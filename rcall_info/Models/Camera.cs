using System.Collections.Generic;

namespace fpv_info.Models
{
    public class Camera : Part
    {
        public Voltage Voltage { get; set; }
        public string Dimension { get; set; }
        public bool OSD { get; set; }
        public bool Mic { get; set; }
        public FOV FOV { get; set; }
        public AspectRatio AspectRatio { get; set; }
        public bool ImageFlip { get; set; }
        public bool DVR { get; set; }
        public HorizontalResolution HorizontalResolution { get; set; }
        public ImageSensor ImageSensor { get; set; }
    }
}
