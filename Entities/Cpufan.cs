using System.ComponentModel.DataAnnotations;

namespace StoreBackEnd.Entities
{
    public class Cpufan
    {
        [Key]
        [StringLength(200)]
        public string Id { get; set; }
        [StringLength(40)]
        public string Title { get; set; }
        [StringLength(40)]
        public string Manufacturer { get; set; }
        [StringLength(250)]
        public string Socket { get; set; }
        [StringLength(40)]
        public string FanSpeed { get; set; }
        [StringLength(40)]
        public string CFM { get; set; }
        [StringLength(40)]
        public string Noise { get; set; }
        [StringLength(40)]
        public string Weight { get; set; }
        [StringLength(40)]
        public string Dimensions { get; set; }
        [StringLength(40)]
        public double Price { get; set; }
    }
}
