using Microsoft.AspNetCore.Mvc.Rendering;


namespace fpv_info.Models.ManagerModels.Parts
{
    public class VideotransmittersManager : PartManager
    {
        public VideoTransmitter Videotransmitter { get; set; }
        public SelectList AntennaConnectors { get; set; }
        public int AntennaConnector_id { get; set; }
        public SelectList Frequency { get; set; }
        public int Frequency_id { get; set; }
        public SelectList Voltages { get; set; }
        public int Voltage_id { get; set; }
        public SelectList Powers { get; set; }
        public int Power1_id { get; set; }
        public int Power2_id { get; set; }
        public int Power3_id { get; set; }
        public int Power4_id { get; set; }
        public int Power5_id { get; set; }
    }
}
