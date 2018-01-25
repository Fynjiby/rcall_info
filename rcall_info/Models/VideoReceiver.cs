using System.Collections.Generic;

namespace fpv_info.Models
{
    public class VideoReceiver : Part
    {
        public float AntennaGain { get; set; }
        public Voltage Voltage { get; set; }
        public int N_Channels { get; set; }
        public AntennaConnector AntennaConnector { get; set; }
        public string Dimension { get; set; }
        public bool RaceBand { get; set; }
        public bool LowBand { get; set; }
        public Frequency Frequency { get; set; }        
    }
}
