using System.ComponentModel.DataAnnotations;

namespace Bachelor.Entities
{
    public class Cpu
    {
        [Key]
        [StringLength(200)]
        public string Id { get; set; }
        [StringLength(40)]
        public string Manufacturer { get; set; }
        [StringLength(40)]
        public string Title { get; set; }
        [StringLength(40)]
        public string Family { get; set; }
        [StringLength(250)]
        public string Socket { get; set; }
        [StringLength(40)]
        public string BaseFrequency { get; set; }
        [StringLength(40)]
        public string BoostFrequency { get; set; }
        [StringLength(40)]
        public string Cores { get; set; }
        [StringLength(40)]
        public string CacheL1 { get; set; }
        [StringLength(40)]
        public string CacheL3 { get; set; }
        [StringLength(40)]
        public string Tdp { get; set; }
        [StringLength(40)]
        public double Price { get; set; }
    }
}
