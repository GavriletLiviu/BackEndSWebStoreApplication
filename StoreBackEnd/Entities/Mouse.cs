using System.ComponentModel.DataAnnotations;

namespace StoreBackEnd.Entities
{
    public class Mouse
    {
        [Key]
        [StringLength(200)]
        public string Id { get; set; }
        [StringLength(40)]
        public string Title { get; set; }
        [StringLength(40)]
        public string Manufacturer { get; set; }
        [StringLength(40)]
        public string Connection { get; set; }
        [StringLength(40)]
        public string Sensor { get; set; }
        [StringLength(40)]
        public string Resolution { get; set; }
        [StringLength(40)]
        public string Buttons { get; set; }
        [StringLength(40)]
        public string Weight { get; set; }
        [StringLength(40)]
        public string Dimensions { get; set; }
        [StringLength(40)]
        public double Price { get; set; }
    }
}
