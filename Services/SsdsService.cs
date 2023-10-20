using Bachelor.Entities;
using StoreBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SsdsService
    {
        private List<Ssd> _ssds;
        public SsdsService()
        {
            _ssds = new List<Ssd>()
            {
                new Ssd
                {
                    Id= "SSDSEAGATEIRONWOLF510192TBNVME",
                     Title= "Ironwolf 510",
                     Manufacturer= "Seagate",
                     Capacity= "1.92TB",
                     Connector= "M.2",
                     Cache= "2048MB",
                    MemoryType= "3d TLC",
                       FormFactor= "80mm",
                        Price= 3020
                },new Ssd
                {
                    Id= "SSDSAMSUNGPM883768TB",
                     Title= "PM883 7.68TB",
                     Manufacturer= "Samsung",
                     Capacity= "7.68TB",
                     Connector= "SATA III",
                     Cache= "2048MB",
                    MemoryType= "TLC",
                       FormFactor= "2.5 inch",
                        Price= 8342
                }
            };
        }
        public List<Ssd> GetSsds()
        {
            return _ssds;
        }

        public Ssd RetrieveSsd(string id)
        {
            foreach (Ssd c in _ssds)
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
