using StoreBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ScreensService
    {
        private List<Screen> _screens;
        public ScreensService()
        {
            _screens = new List<Screen>()
            {
                new Screen
                {
                    Id= "MONITORLG86UH5FH",
                   Title= "86UH5-H 4K 16:9 120Hz",
                 Manufacturer= "LG",
                  Size= "86inch",
                  Resolution= "3840x2160",
                  Refresh= "120Hz",
                  Response= "8ms",
                  Ports= "2xDisplayPort 3xHDMI",
                   Format= "16:9",
                   Price= 28356
                },
                new Screen
                {
                      Id= "MONITORSAMSUNGFLIPWMAL85INCH4K",
                   Title= "Flip WMA-L Series 4k",
                 Manufacturer= "Samsung",
                  Size= "85inch",
                  Resolution= "3840x2160",
                  Refresh= "120Hz",
                  Response= "8ms",
                  Ports= "2xDisplayPort 3xHDMI",
                   Format= "16:9",
                   Price= 24845
                }
            };
        }
        public List<Screen> GetScreens()
        {
            return _screens;
        }

        public Screen RetrieveScreens(string id)
        {
            foreach (Screen c in _screens)
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
