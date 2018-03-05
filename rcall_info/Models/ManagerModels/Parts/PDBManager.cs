using Microsoft.AspNetCore.Mvc.Rendering;


namespace fpv_info.Models.ManagerModels.Parts
{
    public class PDBManager : PartManager
    {
        public PDB PDB { get; set; }
        public SelectList PDBTypes { get; set; }
        public int PDBType_id { get; set; }
        public SelectList InstallDimensions { get; set; }
        public int InstallDimension_id { get; set; }
        public SelectList Voltages { get; set; }
        public int Voltage_id { get; set; }
        public SelectList BECs { get; set; }
        public int BEC1_id { get; set; }
        public int BEC2_id { get; set; }
        public int BEC3_id { get; set; }
    }
}
