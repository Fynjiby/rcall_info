using Microsoft.AspNetCore.Mvc.Rendering;


namespace fpv_info.Models.ManagerModels.Parts
{
    public class MotorsManager : PartManager
    {
        public Motor Motor { get; set; }
        public SelectList InstallDimensions { get; set; }
        public int InstallDimension_id { get; set; }
        public SelectList KVs { get; set; }
        public int KV_id { get; set; }
        public SelectList Voltages { get; set; }
        public int Voltage_id { get; set; }
        public SelectList Measurements { get; set; }
        public int Measurement1_id { get; set; }
        public int Measurement2_id { get; set; }
        public int Measurement3_id { get; set; }
        public int Measurement4_id { get; set; }
        public int Measurement5_id { get; set; }
    }
}
