using System.ComponentModel.DataAnnotations;

namespace StoreBackEnd.Entities
{
    public class Speakers
    {
        [Key]
        [StringLength(200)]
        public string Id { get; set; }
        [StringLength(40)]
        public string Title { get; set; }
        [StringLength(40)]
        public string Manufacturer { get; set; }
        [StringLength(40)]
        public string Type { get; set; }
        [StringLength(40)]
        public string Topology { get; set; }
        [StringLength(40)]
        public string Amplification { get; set; }
        [StringLength(250)]
        public string Drivers { get; set; }
        [StringLength(40)]
        public string Power { get; set; }
        [StringLength(40)]
        public string Connectivity { get; set; }
        [StringLength(40)]
        public string Weight { get; set; }
        [StringLength(40)]
        public double Price { get; set; }
    }
}
