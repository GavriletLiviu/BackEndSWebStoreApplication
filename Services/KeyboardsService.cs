using StoreBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class KeyboardsService
    {
        private List<Keyboard> _keyboards;
        public KeyboardsService()
        {
            _keyboards = new List<Keyboard>()
            {
                new Keyboard
                {
                    Id= "KEYLOGITECHG915TKLULTRASLIMLIGHTSPEEDWIRELESSBLUETOOTH",
                  Title= "G915 TKL Ultraslim",
                    Manufacturer= "Logitech",
                 Connect= "wireless and bluetooth",
                 Lights= "individual LED keys",
                 Weight= "81 g",
                 Type= "mechanical",
                 Dimensions= "368x150x22 mm",
                 Price= 1411
                },
                new Keyboard
                {
                     Id= "KEYTHERMALTAKEKBLVTBLBRUS01LEVEL20RGB",
                  Title= "KB-LVT-BLBRUS-01",
                    Manufacturer= "Thermaltake",
                 Connect= "wireless and bluetooth",
                 Lights= "individual LED keys",
                 Weight= "81 g",
                 Type= "mechanical",
                 Dimensions= "368x150x22 mm",
                 Price= 1214
                }
            };
        }
        public List<Keyboard> GetKeyboards()
        {
            return _keyboards;
        }

        public Keyboard RetrieveKeyboards(string id)
        {
            foreach (Keyboard c in _keyboards)
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
