
namespace fpv_info.Models
{
    public class PullMeasurement
    {
        public int Id { get; set; }
        public float LoadCurrent { get; set; }
        public int Pull { get; set; }
        public int Power { get; set; }
        public int Efficiency { get; set; }
        
    }
}
