using System.Collections.Generic;

namespace fpv_info.Models
{
    public class FlightController : Part
    {
        public ProcessorModel Processor { get; set; }
        public Gyro Gyro { get; set; }
        public int N_UART { get; set; }
        public bool PDB { get; set; }
        public bool SlotSD { get; set; }
        public int N_PWMOut { get; set; }
        public Voltage Voltage { get; set; }
        public bool OSD { get; set; }
        public string Dimensions { get; set; }
        public InstallDimension InstallDimension { get; set; }
        public FirmwareModel Firmware { get; set; }
    }
}
