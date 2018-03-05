using Microsoft.AspNetCore.Mvc.Rendering;


namespace fpv_info.Models.ManagerModels.Parts
{
    public class ReceiversManager : PartManager
    {
        public Receiver Receiver { get; set; }
        public SelectList Voltages { get; set; }
        public int Voltage_id { get; set; }
        public SelectList Frequency { get; set; }
        public int Frequency_id { get; set; }
        public SelectList RCProtocols { get; set; }
        public int RCProtocol_id { get; set; }
    }
}
