using System.ComponentModel.DataAnnotations;

namespace StoreBackEnd.Entities
{
    public class Gpu
    {
        [Key]
        [StringLength(200)]
        public string Id { get; set; }
        [StringLength(40)]
        public string Title { get; set; }
        [StringLength(40)]
        public string Manufacturer { get; set; }
        [StringLength(40)]
        public string Slot { get; set; }
        [StringLength(40)]
        public string Processor { get; set; }
        [StringLength(40)]
        public string Cores { get; set; }
        [StringLength(250)]
        public string Technologies { get; set; }
        [StringLength(40)]
        public string Series { get; set; }
        [StringLength(40)]
        public string ProcessorFrequency { get; set; }
        [StringLength(40)]
        public string MemorySize { get; set; }
        [StringLength(40)]
        public string MemoryType { get; set; }
        [StringLength(40)]
        public string MemoryBusSize { get; set; }
        [StringLength(40)]
        public string DirectX { get; set; }
        [StringLength(40)]
        public string OpenGl { get; set; }
        [StringLength(40)]
        public string DisplayPorts { get; set; }
        [StringLength(40)]
        public string HdmiPorts { get; set; }
        [StringLength(40)]
        public string VgaPorts { get; set; }
        [StringLength(40)]
        public string DviPorts { get; set; }
        [StringLength(40)]
        public string PowerPorts { get; set; }
        [StringLength(40)]
        public string Power { get; set; }
        [StringLength(40)]
        public double Price { get; set; }
    }
}
