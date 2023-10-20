using System.ComponentModel.DataAnnotations;

namespace StoreBackEnd.Entities
{
    public class Drive
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
        public string Buffer { get; set; }
        [StringLength(40)]
        public string Connector { get; set; }
        [StringLength(40)]
        public string Format { get; set; }
        [StringLength(40)]
        public double Price { get; set; }
    }
}
