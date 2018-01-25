using System.Collections.Generic;

namespace fpv_info.Models
{
    public class Fuselage : Part
    {
        public FuselageType Type { get; set; }
        public int Wingspan { get; set; }
        public Material Material { get; set; }
    }
}
