using Microsoft.AspNetCore.Mvc.Rendering;


namespace fpv_info.Models.ManagerModels.Parts
{
    public class ESCManager : PartManager
    {
        public ESC ESC { get; set; }
        public SelectList Voltages { get; set; }
        public int Voltage_id { get; set; }
        public SelectList Currents { get; set; }
        public int Current_id { get; set; }
        public int PeakCurrent_id { get; set; }
        public SelectList Firmwares { get; set; }
        public int Firmware_id { get; set; }
        public SelectList InstallDimensions { get; set; }
        public int InstallDimension_id { get; set; }
        public SelectList Processors { get; set; }
        public int Processor_id { get; set; }
    }
}
