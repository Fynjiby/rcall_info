using System.Collections.Generic;

namespace fpv_info.Models
{
    public class AccessoryModel : Part
    {
        public AccessoryType Type { get; set; }

        public AccessoryModel() => IsCompared = false;
    }
}
