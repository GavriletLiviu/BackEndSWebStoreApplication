using StoreBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SpeakersService
    {
        private List<Speakers> _speakers;
        public SpeakersService()
        {
            _speakers = new List<Speakers>()
            {
                new Speakers
                {
                    Id= "SPEAKERCREATIVESTUDIOEMUXM720",
                    Title= "Studio E-MU XM7",
                    Manufacturer= "Creative",
                    Type= "2.0",
                    Topology= "two-way",
                    Amplification= "passive - 60W",
                    Drivers= "1 inch silk dome, 5 inch woofer",
                    Power= "60W",
                    Connectivity= "binding-posts",
                    Weight= "4.35 kg",
                    Price=  774
                },
                new Speakers
                {
                    Id= "SPEAKEREDIFIER51S760D540W",
                    Title= "S 760D 5.1",
                    Manufacturer= "Edifier",
                    Type= "5.1",
                    Topology= "two-way + subwoofer",
                    Amplification= "60 W tops, 240 W subwoofer",
                    Drivers= "tops: 1inch tweeter, 3.5inch woofer + 10 inch subwoofer",
                    Power= "540W",
                    Connectivity= "3 x optical, 1 x coaxial, 1 x 5.1 analog",
                    Weight= "subwoofer 22.1kg, satellite 13kg",
                    Price=  2660
                }
            };
        }
        public List<Speakers> GetSpeakers()
        {
            return _speakers;
        }

        public Speakers RetrieveSpeakers(string id)
        {
            foreach (Speakers c in _speakers)
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
