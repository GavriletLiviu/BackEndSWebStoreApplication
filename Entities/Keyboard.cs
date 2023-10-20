using System.ComponentModel.DataAnnotations;

namespace StoreBackEnd.Entities
{
    public class Keyboard
    {
        [Key]
        [StringLength(200)]
        public string Id { get; set; }
        [StringLength(40)]
        public string Title { get; set; }
        [StringLength(40)]
        public string Manufacturer { get; set; }
        [StringLength(40)]
        public string Connect { get; set; }
        [StringLength(40)]
        public string Lights { get; set; }
        [StringLength(40)]
        public string Weight { get; set; }
        [StringLength(40)]
        public string Type { get; set; }
        [StringLength(40)]
        public string Dimensions { get; set; }
        [StringLength(40)]
        public double Price { get; set; }
    }
}
