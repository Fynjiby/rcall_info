using Microsoft.AspNetCore.Mvc.Rendering;


namespace fpv_info.Models.ManagerModels.Parts
{
    public class AntennasManager : PartManager
    {
        public Antenna Antenna { get; set; }
        public SelectList Frequency { get; set; }
        public int Frequency_id { get; set; }
        public SelectList AntennaConnectors { get; set; }
        public int AntennaConnector_id { get; set; }
    }
}
