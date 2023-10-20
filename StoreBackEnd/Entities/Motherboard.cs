using System.ComponentModel.DataAnnotations;

namespace StoreBackEnd.Entities
{
    public class Motherboard
    {
        [Key]
        [StringLength(200)]
        public string Id { get; set; }
        [StringLength(40)]
        public string Title { get; set; }
        [StringLength(40)]
        public string Manufacturer { get; set; }
        [StringLength(250)]
        public string CpuSocket { get; set; }
        [StringLength(40)]
        public string Chipset { get; set; }
        [StringLength(40)]
        public string SupportedCpu { get; set; }
        [StringLength(40)]
        public string MemoryType { get; set; }
        [StringLength(40)]
        public string MemoryCapacity { get; set; }
        [StringLength(40)]
        public string MemorySlots { get; set; }
        [StringLength(40)]
        public string PcieVersion { get; set; }
        [StringLength(250)]
        public string AudioCodec { get; set; }
        [StringLength(40)]
        public string Lan { get; set; }
        [StringLength(250)]
        public string Connectivity { get; set; }
        [StringLength(250)]
        public string RaidVersions { get; set; }
        [StringLength(40)]
        public string SataInterfaces { get; set; }
        [StringLength(40)]
        public string PcieFullSlots { get; set; }
        [StringLength(40)]
        public string PcieSlots { get; set; }
        [StringLength(40)]
        public string M2Slots { get; set; }
        [StringLength(250)]
        public string Technologies { get; set; }
        [StringLength(40)]
        public string Dimensions { get; set; }
        [StringLength(40)]
        public double Price { get; set; }
    }
}
