using Microsoft.AspNetCore.Mvc.Rendering;


namespace fpv_info.Models.ManagerModels.Parts
{
    public class ChargersManager : PartManager
    {
        public Charger Charger { get; set; }
        public SelectList Voltages { get; set; }
        public int Voltage_id { get; set; }
        public int PbBatteryVoltage_id { get; set; }
        public SelectList Powers { get; set; }
        public int PowerCharge_id { get; set; }
        public int PowerDischarge_id { get; set; }
        
    }
}
