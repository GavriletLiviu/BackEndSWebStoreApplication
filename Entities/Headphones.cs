using System.ComponentModel.DataAnnotations;

namespace StoreBackEnd.Entities
{
    public class Headphones
    {
        [Key]
        [StringLength(200)]
        public string Id { get; set; }
        [StringLength(40)]
        public string Title { get; set; }
        [StringLength(40)]
        public string Manufacturer { get; set; }
        [StringLength(40)]
        public string Connectivity { get; set; }
        [StringLength(40)]
        public string Impedance { get; set; }
        [StringLength(40)]
        public string Microphone { get; set; }
        [StringLength(40)]
        public double Price { get; set; }
    }
}
