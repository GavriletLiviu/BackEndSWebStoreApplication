using StoreBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class FansService
    {
        private List<Fan> _fans;
        public FansService()
        {
            _fans = new List<Fan>()
            {
                new Fan
                {
                    Id="FANNOCTUANFA14PWM",
                    Title= "NF-A14 PWM",
                    Manufacturer= "Noctua",
                    Size= "140mm",
                    Dimensions= "140x140x25mm",
                    Cfm= "140,2 cubic meters / hour",
                    Mtbf= "150000 hours",
                    Noise= "24,6 dB",
                    Price=  125
                },
                new Fan
                {
                  Id="FANBEQUIETPUREWINGS2120MMPWM",
                    Title= "Pure Wings 2",
                    Manufacturer= "Be Quiet!",
                    Size= "120mm",
                    Dimensions= "120x120x25mm",
                    Cfm= "51,4-87 cubic meters / hour",
                    Mtbf= "80000 hours",
                    Noise= "20,2 dB",
                    Price=  55
                }
            };
        }
        public List<Fan> GetFans()
        {
            return _fans;
        }

        public Fan RetrieveFan(string id)
        {
            foreach (Fan c in _fans)
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
