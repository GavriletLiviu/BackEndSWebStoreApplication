using System.ComponentModel.DataAnnotations;

namespace StoreBackEnd.Entities
{
    public class Power
    {
        [Key]
        [StringLength(200)]
        public string Id { get; set; }
        [StringLength(40)]
        public string Title { get; set; }
        [StringLength(40)]
        public string Manufacturer { get; set; }
        [StringLength(40)]
        public string MaxPower { get; set; }
        [StringLength(40)]
        public string ConnectorSata { get; set; }
        [StringLength(40)]
        public string ConnectorPeripherial { get; set; }
        [StringLength(40)]
        public string ConnectorMotherboard { get; set; }
        [StringLength(40)]
        public string ConnectorCpu { get; set; }
        [StringLength(40)]
        public string ConnectorPcie6 { get; set; }
        [StringLength(40)]
        public string ConnectorPcie8 { get; set; }
        [StringLength(40)]
        public string Format { get; set; }
        [StringLength(40)]
        public string Modularity { get; set; }
        [StringLength(40)]
        public double Price { get; set; }
    }
}
