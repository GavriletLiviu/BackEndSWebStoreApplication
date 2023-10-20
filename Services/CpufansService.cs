using StoreBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CpufansService
    {
        private List<Cpufan> _cpufans;
        public CpufansService()
        {
            _cpufans = new List<Cpufan>()
            {
                new Cpufan
                {
                    Id= "CPUFANNOCTUANH-U12ACHROMAXBLACK",
                    Title= "NH-U12A Chromax Black",
                     Manufacturer= "Noctua",
                   Socket= "AM4, AM3, AM2, FM1, FM2, 1700, 1200, 1150, 1151, 1155, 1156, 2011, 2066",
                   FanSpeed= "2000 rpm",
                    CFM="60.09 cubic meters / hour",
                   Noise= "22.6 dB",
                    Weight= "1220g",
                   Dimensions= "125x58x158mm",
                  Price= 833
                },
                new Cpufan
                {
                    Id= "CPUFANBEQUIETDARKROCKPROTR4",
                    Title= "Dark Rock Pro TR4",
                     Manufacturer= "Be Quiet",
                   Socket= "sTRX4/TRX4",
                   FanSpeed= "1200-1500rpm",
                    CFM="99",
                   Noise= "24,3 dB",
                    Weight= "1180g",
                   Dimensions= "145x136x162.8mm",
                  Price= 543
                }
            };
        }
        public List<Cpufan> GetCpuFans()
        {
            return _cpufans;
        }

        public Cpufan RetrieveCpufan(string id)
        {
            foreach (Cpufan c in _cpufans)
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
