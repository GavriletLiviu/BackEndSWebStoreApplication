using Bachelor.Entities;
using StoreBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DrivesService
    {
        private List<Drive> _drives;
        public DrivesService()
        {
            _drives = new List<Drive>()
            {
                new Drive
                {
                   Id= "HDDSEAGATEIRONWOLFPRONAS20TB",
                   Title= "Iron Wolf Pro Nas 20TB",
                   Manufacturer= "Seagate",
                   Capacity= "20TB",
                   Buffer= "256 MB",
                   Connector= "SATA-III",
                   Format= "3.5 inch",
                   Price=  2700
                },
                new Drive
                {
                   Id= "HDDSEAGATEENTERPRISECAPACITY1TB",
                   Title= "Enterprise Capacity 1TB",
                   Manufacturer= "Seagate",
                   Capacity= "1TB",
                   Buffer= "128 MB",
                   Connector= "SAS",
                   Format= "3.5 inch",
                   Price=  1214
                }
            };
        }
        public List<Drive> GetDrives()
        {
            return _drives;
        }

        public Drive RetrieveDrives(string id)
        {
            foreach (Drive c in _drives)
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
