
using System.Collections.Generic;

namespace fpv_info.Models
{
    public class Measurement : BaseModel
    {
        public Voltage Voltage { get; set; }
        public PropType PropType { get; set; }
        public ICollection<PullMeasurement> PullMeasurement { get; set; }
        public Link Source { get; set; }
    }
}
