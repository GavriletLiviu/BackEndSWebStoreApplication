using System.ComponentModel.DataAnnotations;

namespace StoreBackEnd.Entities
{
    public class Fan
    {
        [Key]
        [StringLength(200)]
        public string Id { get; set; }
        [StringLength(40)]
        public string Title { get; set; }
        [StringLength(40)]
        public string Manufacturer { get; set; }
        [StringLength(40)]
        public string Size { get; set; }
        [StringLength(40)]
        public string Dimensions { get; set; }
        [StringLength(40)]
        public string Cfm { get; set; }
        [StringLength(40)]
        public string Mtbf { get; set; }
        [StringLength(40)]
        public string Noise { get; set; }
        [StringLength(40)]
        public double Price { get; set; }
    }
}
