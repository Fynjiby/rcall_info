
namespace fpv_info.Models
{
    public class Measurement : BaseModel
    {
        public Voltage Voltage { get; set; }
        public PropType PropType { get; set; }
        public float LoadCurrent { get; set; }
        public int Pull { get; set; }
        public int Power { get; set; }
        public int Efficiency { get; set; }
        public Link Source { get; set; }
    }
}
