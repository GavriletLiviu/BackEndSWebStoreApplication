using System.ComponentModel.DataAnnotations;

namespace Services.Entities
{
    public class ComputerCase
    {
        [Key]
        [StringLength(200)]
        public string Id { get; set; }
        [StringLength(40)]
        public string Title { get; set; }
        [StringLength(40)]
        public string Manufacturer { get; set; }
        [StringLength(40)]
        public string Fans { get; set; }
        [StringLength(40)]
        public string Type { get; set; }
        [StringLength(40)]
        public string FrontInputs { get; set; }
        [StringLength(40)]
        public string Dimensions { get; set; }
        [StringLength(40)]
        public string MotherboardFormat { get; set; }
        [StringLength(40)]
        public string Color { get; set; }
        [StringLength(40)]
        public string Weight { get; set; }
        [StringLength(40)]
        public string IncludedFans { get; set; }
        [StringLength(40)]
        public double Price { get; set; }
    }
}
