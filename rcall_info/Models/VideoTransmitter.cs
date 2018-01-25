using System.Collections.Generic;

namespace fpv_info.Models
{
    public class VideoTransmitter : Part
    {
        public Voltage Voltage { get; set; }
        public int N_Channels { get; set; }
        public ICollection<Power> Powers { get; set; }
        public bool VTXControl { get; set; }
        public bool RaceBand { get; set; }
        public bool LowBand { get; set; }
        public bool Mic { get; set; }
        public string BEC { get; set; }
        public AntennaConnector AntennaConnector { get; set; }
        public bool PitMode { get; set; }
        public string Dimension { get; set; }
        public Frequency Frequency { get; set; }
    }
}
