using System.Collections.Generic;

namespace fpv_info.Models
{
    public class ESC : Part
    {
        public Voltage Voltage { get; set; }
        public Current Current { get; set; }
        public Current PeakCurrent { get; set; }
        public bool BEC { get; set; }
        public FirmwareModel Firmware { get; set; }
        public string Dimensions { get; set; }
        public InstallDimension InstallDimension { get; set; }
        public bool Oneshot125 { get; set; }
        public bool Oneshot42 { get; set; }
        public bool Multishot { get; set; }
        public bool DShot150 { get; set; }
        public bool DShot300 { get; set; }
        public bool DShot600 { get; set; }
        public bool DShot1200 { get; set; }
        public ProcessorModel Processor { get; set; }
    }
}
