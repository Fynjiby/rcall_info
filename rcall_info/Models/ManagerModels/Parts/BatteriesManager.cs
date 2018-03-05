using Microsoft.AspNetCore.Mvc.Rendering;


namespace fpv_info.Models.ManagerModels.Parts
{
    public class BatteriesManager : PartManager
    {
        public Battery Battery { get; set; }
        public SelectList Voltages { get; set; }
        public int Voltage_id { get; set; }
        public SelectList BattaryTypes { get; set; }
        public int BattaryType_id { get; set; }
        public SelectList Capacity { get; set; }
        public int Capacity_id { get; set; }
        public SelectList DischargeRates { get; set; }
        public int DischargeRate_id { get; set; }
    }
}
