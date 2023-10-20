using StoreBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MiceService
    {
        private List<Mouse> _mice;
        public MiceService()
        {
            _mice = new List<Mouse>()
            {
                new Mouse
                {
                    Id= "MOUSELOGITECHMXMASTER1600DPI",
                     Title= "MX Master 1600dpi",
                      Manufacturer= "Logitech",
                      Connection= "wireless",
                      Sensor= "laser",
                      Resolution= "1600dpi",
                       Buttons= "5 buttons one scroll",
                       Weight="145g",
                       Dimensions= "126x85x48.4mm",
                       Price=  1006
                },
                new Mouse
                {
                  Id= "MOUSERAZERDEATHADDERV3PRO30KDPI",
                     Title= "Death Adder V3 Pro",
                      Manufacturer= "Razer",
                      Connection= "wireless",
                      Sensor= "laser",
                      Resolution= "1600dpi",
                       Buttons= "5 buttons one scroll",
                       Weight="145g",
                       Dimensions= "126x85x48.4mm",
                       Price=  839
                }
            };
        }
        public List<Mouse> GetMice()
        {
            return _mice;
        }

        public Mouse RetrieveMice(string id)
        {
            foreach (Mouse c in _mice)
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
