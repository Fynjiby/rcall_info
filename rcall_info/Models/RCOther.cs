using System.Collections.Generic;

namespace fpv_info.Models
{
    public class RCOther : Part
    {
        public RCOtherType Type { get; set; }

        public RCOther() => IsCompared = false;
    }
}
