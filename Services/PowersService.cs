using StoreBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PowersService
    {
        private List<Power> _powers;
        public PowersService()
        {
            _powers = new List<Power>()
            {
                new Power
                {
                  Id= "PWRSEASONICPRIMETX1300WTITANIUM",
                  Title= "Prime TX 1300W Titanium",
                   Manufacturer= "Seasonic",
                   MaxPower= "1300W",
                   ConnectorSata= "16xSATA",
                   ConnectorPeripherial= "6xPeripherial",
                   ConnectorMotherboard= "20/24pin",
                   ConnectorCpu= "3xCPU 4+4pin",
                   ConnectorPcie6= "",
                   ConnectorPcie8= "8xPCIe 8pin",
                   Format= "ATX",
                   Modularity= "fuly-modular",
                   Price= 2951
                },
                new Power
                {
                   Id= "PWRASUSROGTHOR1600WTITANIUM",
                  Title= "Rog Thor 1600W",
                   Manufacturer= "Asus",
                   MaxPower= "1600W",
                   ConnectorSata= "16xSATA",
                   ConnectorPeripherial= "6xPeripherial",
                   ConnectorMotherboard= "20/24pin",
                   ConnectorCpu= "3xCPU 4+4pin",
                   ConnectorPcie6= "",
                   ConnectorPcie8= "8xPCIe 8pin",
                   Format= "ATX",
                   Modularity= "fuly-modular",
                   Price= 4677
                }
            };
        }
        public List<Power> GetPowers()
        {
            return _powers;
        }

        public Power RetrievePowers(string id)
        {
            foreach (Power c in _powers)
            {
                if (c.Id == id)
                {
                    return c;
                }
            }
            return null;
        }
    }
}
