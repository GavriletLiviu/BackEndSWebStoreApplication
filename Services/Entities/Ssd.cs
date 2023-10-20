using System.ComponentModel.DataAnnotations;

namespace StoreBackEnd.Entities
{
    public class Ssd
    {
        [Key]
        [StringLength(200)]
        public string Id { get; set; }
        [StringLength(40)]
        public string Title { get; set; }
        [StringLength(40)]
        public string Manufacturer { get; set; }
        [StringLength(40)]
        public string Capacity { get; set; }
        [StringLength(40)]
        public string Connector { get; set; }
        [StringLength(40)]
        public string Cache { get; set; }
        [StringLength(40)]
        public string MemoryType { get; set; }
        [StringLength(40)]
        public string FormFactor { get; set; }
        [StringLength(40)]
        public double Price { get; set; }
    }
}
