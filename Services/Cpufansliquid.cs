using Bachelor.Entities;
using StoreBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CpufansliquidService
    {
        private List<Cpufanliquid> _cpufansliquid;
        public CpufansliquidService()
        {
            _cpufansliquid = new List<Cpufanliquid>()
            {
                new Cpufanliquid
                {
                  Id= "CPUFANLIQUIDBEQUIETSILENTLOOP2360MM",
                  Title= "Silent Loop 2 360",
                   Manufacturer= "Be Quiet",
                   Size= "360mm",
                   Socket= "1150, 1151, 1155, 1200, 2066, AM4, AM3, sTRX4",
                   FanSpeed= "2200rpm",
                   PumpSpeed="2800rpm",
                   Noise="11,7-39,8dB",
                   Weight= "1330g",
                  Dimensions= "120x52x394mm",
                  FanLed= "no",
                  WaterblockLed= "no",
                  Price= 996
                },
                new Cpufanliquid
                {
                   Id= "CPUFANLIQUIDCORSAIRICUEH100IELITELCD240MM",
                  Title= "iCue H100i Elite Lcd Display 240mm",
                   Manufacturer= "Corsair",
                   Size= "240mm",
                   Socket= "1150, 1151, 1155, 1200, 2066, AM4, AM3, sTRX4",
                   FanSpeed= "2000rpm",
                   PumpSpeed="2200rpm",
                   Noise="10-30,4dB",
                   Weight= "1000g",
                  Dimensions= "277x120x27mm",
                  FanLed= "Yes",
                  WaterblockLed= "Display",
                  Price= 1769
                }
            };
        }
        public List<Cpufanliquid> GetCpuFansLiquid()
        {
            return _cpufansliquid;
        }

        public Cpufanliquid RetrieveCpufanliquid(string id)
        {
            foreach (Cpufanliquid c in _cpufansliquid)
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
