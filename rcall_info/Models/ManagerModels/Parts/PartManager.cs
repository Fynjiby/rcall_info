using Microsoft.AspNetCore.Mvc.Rendering;

namespace fpv_info.Models.ManagerModels.Parts
{
    public class PartManager
    {
        public SelectList Manufacturers { get; set; }
        public int Manufacturer_id { get; set; }
        public FileModel Image { get; set; }
        public FileModel Image1 { get; set; }
        public FileModel Image2 { get; set; }
        public FileModel Image3 { get; set; }
        public FileModel Image4 { get; set; }
        public FileModel Image5 { get; set; }
        public FileModel Image6 { get; set; }
        public FileModel Image7 { get; set; }
        public FileModel Image8 { get; set; }
        public FileModel Image9 { get; set; }
        public Link MediaLink { get; set; }
        public Link MediaLink1 { get; set; }
        public Link MediaLink2 { get; set; }
        public Link MediaLink3 { get; set; }
        public Link MediaLink4 { get; set; }
        public Link SourceLink { get; set; }
        public Link SourceLink1 { get; set; }
        public Link SourceLink2 { get; set; }
        public Link SourceLink3 { get; set; }
        public Link SourceLink4 { get; set; }
        public Link StoreLink { get; set; }
        public Link StoreLink2 { get; set; }
        public Link StoreLink3 { get; set; }
        public Link StoreLink4 { get; set; }
        public Link StoreLink5 { get; set; }
    }
}
