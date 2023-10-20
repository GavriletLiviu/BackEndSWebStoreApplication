using StoreBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RamsService
    {
        private List<Ram> _rams;
        public RamsService()
        {
            _rams = new List<Ram>()
            {
                new Ram
                {
                   Id= "GSKILLRIPJAWSS5BLACK2x16GB",
                   Title= "Ripjaws S5 Black",
                  Manufacturer= "GSkill",
                  Capacity= "16GB",
                  Generation= "DDR4",
                  Kit="2x16GB",
                  Frequency= "5600Mhz",
                  Voltage= "1.35V",
                  Latency= "CL 36",
                  Radiator= "Yes",
                  Overclock= "XMP 2.0",
                   Price=  2458
                },
                new Ram
                {
                       Id= "RAMCORSAIRVENGEANCERGBPRO128GB4X323600MHZCL18",
                   Title= "Vengeance Rgb Pro",
                  Manufacturer= "Corsair",
                  Capacity= "32GB",
                  Generation= "DDR4",
                  Kit="4x32GB",
                  Frequency= "3600Mhz",
                  Voltage= "1.35V",
                  Latency= "CL 36",
                  Radiator= "Yes",
                  Overclock= "XMP 2.0",
                   Price=  6455
                }
            };
        }
        public List<Ram> GetRams()
        {
            return _rams;
        }

        public Ram RetrieveRams(string id)
        {
            foreach (Ram c in _rams)
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
