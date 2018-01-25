using System.Collections.Generic;

namespace fpv_info.Models
{
    public class Part
    {
        public int Id { get; set; }
        public string Name_en { get; set; }
        public string Name_ru { get; set; }
        public string Description_en { get; set; }
        public string Description_ru { get; set; }
        public Company Manufacturer { get; set; }
        public ICollection<FileModel> Images { get; set; }
        public ICollection<Link> MediaLinks { get; set; }
        public ICollection<Link> SourceLinks { get; set; }
        public ICollection<Link> StoreLinks { get; set; }
        public float Weight { get; set; }
        public bool IsCompared { get; set; }
        public string Сomment { get; set; }

        public Part() => IsCompared = true;

    }
}
