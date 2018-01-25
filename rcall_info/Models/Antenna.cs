using System.Collections.Generic;

namespace fpv_info.Models
{
    public class Antenna : Part
    {
        public Frequency Frequency { get; set; }
        public AntennaConnector AntennaConnector { get; set; }
        public float Gain { get; set; }
    }
}
