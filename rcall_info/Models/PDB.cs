using System.Collections.Generic;

namespace fpv_info.Models
{
    public class PDB : Part
    {
        public Voltage InputVoltage { get; set; }
        public PDBType PDBType { get; set; }
        public ICollection<BEC> BECs { get; set; }
        public bool CurrentSensor { get; set; }
        public string Dimensions { get; set; }
        public InstallDimension InstallDimension { get; set; }
    }
}
