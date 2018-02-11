using Microsoft.AspNetCore.Mvc.Rendering;


namespace fpv_info.Models.ManagerModels.Parts
{
    public class FCManager:PartManager
    {
        public FlightController FC { get; set; }
        public SelectList Processors { get; set; }
        public int Processor_id { get; set; }
        public SelectList Gyros { get; set; }
        public int Gyro_id { get; set; }
        public SelectList Voltages { get; set; }
        public int Voltage_id { get; set; }
        public SelectList InstallDimensions { get; set; }
        public int InstallDimension_id { get; set; }
        public SelectList Firmwares { get; set; }
        public int Firmware_id { get; set; }

    }
}
