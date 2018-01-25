namespace fpv_info.Models
{
    public class Link : BaseModel
    {
        public string Path { get; set; }
        public Store Store { get; set; }
        public LinkType LinkType { get; set; }

    }
}
