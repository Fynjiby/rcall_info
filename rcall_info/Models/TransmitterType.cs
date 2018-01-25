
namespace fpv_info.Models
{
    public class TransmitterType : BaseModel
    {
        public TransmitterType Type { get; set; }
        public Frequency Frequency { get; set; }
        public Power Power { get; set; }
    }
}
