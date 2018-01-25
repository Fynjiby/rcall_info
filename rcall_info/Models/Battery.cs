using System.Collections.Generic;

namespace fpv_info.Models
{
    public class Battery : Part
    {
        public Voltage Voltage { get; set; }
        public string Dimension { get; set; }
        public BattaryType BattaryType { get; set; }
        public Capacity Capacity { get; set; }
        public DischargeRate DischargeRate { get; set; }
    }
}
