using System.ComponentModel.DataAnnotations;

namespace StoreBackEnd.Entities
{
    public class Screen
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
        public string Resolution { get; set; }
        [StringLength(40)]
        public string Refresh { get; set; }
        [StringLength(40)]
        public string Response { get; set; }
        [StringLength(40)]
        public string Ports { get; set; }
        [StringLength(40)]
        public string Format { get; set; }
        [StringLength(40)]
        public double Price { get; set; }
    }
}
