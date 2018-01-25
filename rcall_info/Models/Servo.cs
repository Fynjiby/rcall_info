using System.Collections.Generic;

namespace fpv_info.Models
{
    public class Servo : Part
    {
        public Voltage Voltage { get; set; }
        public string Dimension { get; set; }
        public string OperatingSpeed { get; set; }
        public string StallTorque { get; set; }
    }
}
