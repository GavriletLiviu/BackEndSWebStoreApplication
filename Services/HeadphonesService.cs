using StoreBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class HeadphonesService
    {
        private List<Headphones> _headphones;
        public HeadphonesService()
        {
            _headphones = new List<Headphones>()
            {
                new Headphones
                {
                    Id= "HEADPHONELOGITECHH800",
                  Title= "H800",
                  Manufacturer= "Logitech",
                  Connectivity= "wireless",
                  Impedance= "32 ohm",
                  Microphone= "yes",
                  Price= 1757
                },
                new Headphones
                {
                    Id= "HEADPHONEAUDIOTECHNICAATHG1",
                  Title= "ATH-G1",
                  Manufacturer= "Audio Technica",
                  Connectivity= "wireless",
                  Impedance= "32 ohm",
                  Microphone= "yes",
                  Price= 800
                }
            };
        }
        public List<Headphones> GetHeadphones()
        {
            return _headphones;
        }

        public Headphones RetrieveHeadphones(string id)
        {
            foreach (Headphones c in _headphones)
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
