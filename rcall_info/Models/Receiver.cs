using System.Collections.Generic;

namespace fpv_info.Models
{
    public class Receiver : Part
    {
        public Voltage Voltage { get; set; }
        public string Dimension { get; set; }
        public Frequency Frequency { get; set; }
        public bool SPort { get; set; }
        public RCProtocol Output { get; set; }
    }
}
