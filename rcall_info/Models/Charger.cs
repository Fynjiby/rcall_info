using System.Collections.Generic;

namespace fpv_info.Models
{
    public class Charger : Part
    {
        public Voltage Voltage { get; set; }
        public string Dimension { get; set; }
        public Power PowerCharge { get; set; }
        public Power PowerDischarge { get; set; }
        public string ChargeCurrentRange { get; set; }
        public string DischargeCurrentRange { get; set; }
        public string CurrentDrainBalancing { get; set; }
        public int NiCd_NiMHCellCount { get; set; }
        public int LiPoCellCount { get; set; }
        public Voltage PbBatteryVoltage { get; set; }
    }
}
