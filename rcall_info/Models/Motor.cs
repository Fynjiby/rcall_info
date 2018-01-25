using System.Collections.Generic;

namespace fpv_info.Models
{
    public class Motor: Part
    {
        public MotorKV KV { get; set; }
        public InstallDimensionMotor InstallDimension { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public float ShaftDiameter { get; set; }
        public float MotorMountHoleSize { get; set; }
        public Voltage Voltage { get; set; }
        public ICollection<Measurement> Measurement { get; set; }
    }
}
