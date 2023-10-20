using System.ComponentModel.DataAnnotations;

namespace StoreBackEnd.Entities
{
    public class Ram
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
        public string Generation { get; set; }
        [StringLength(40)]
        public string Kit { get; set; }
        [StringLength(40)]
        public string Frequency { get; set; }
        [StringLength(40)]
        public string Voltage { get; set; }
        [StringLength(40)]
        public string Latency { get; set; }
        [StringLength(40)]
        public string Radiator { get; set; }
        [StringLength(40)]
        public string Overclock { get; set; }
        [StringLength(40)]
        public double Price { get; set; }
    }
}
