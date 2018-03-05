using Microsoft.AspNetCore.Mvc.Rendering;


namespace fpv_info.Models.ManagerModels.Parts
{
    public class ServosManager : PartManager
    {
        public Servo Servo { get; set; }
        public SelectList Voltages { get; set; }
        public int Voltage_id { get; set; }
    }
}
