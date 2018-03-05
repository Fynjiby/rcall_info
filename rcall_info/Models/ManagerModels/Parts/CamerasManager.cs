using Microsoft.AspNetCore.Mvc.Rendering;


namespace fpv_info.Models.ManagerModels.Parts
{
    public class CamerasManager : PartManager
    {
        public Camera Camera { get; set; }
        public SelectList Voltages { get; set; }
        public int Voltage_id { get; set; }
        public SelectList FOVs { get; set; }
        public int FOV_id { get; set; }
        public SelectList AspectsRatio { get; set; }
        public int AspectRatio_id { get; set; }
        public SelectList HorizontalResolutions { get; set; }
        public int HorizontalResolution_id { get; set; }
        public SelectList ImageSensors { get; set; }
        public int ImageSensor_id { get; set; }
    }
}
