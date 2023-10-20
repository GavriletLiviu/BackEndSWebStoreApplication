using Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ComputerCaseService
    {
        private List<ComputerCase> _cases;
        public ComputerCaseService()
        {
            _cases = new List<ComputerCase>()
            {
                new ComputerCase
                {
                    Id= "CSLIANLIO11DYNAMICXLROG",
                    Title= "O11 Dynamic XL",
                    Manufacturer= "Lian Li",
                    Fans= "10 x 120mm",
                    Type= "Full Tower",
                    FrontInputs= "1xUsb 3.1TypeC, 4xUsb3.0, 1xHDAudio",
                    Dimensions= "285x513x471mm",
                    MotherboardFormat= "ATX, microATX, ExtendedATX, ITX",
                    Color= "black",
                    Weight= "13.75kg",
                    IncludedFans= "0",
                    Price=1422
                },new ComputerCase
                {
                    Id= "CSLIANLILANCOOL215",
                    Title= "Lancool 215",
                    Manufacturer= "Lian Li",
                    Fans= "7 x 120mm or 4 x 140mm / 2 x 120mm",
                    Type= "Middle Tower",
                    FrontInputs= "2xUsb3.0, 1xHDAudio, 1xLed Control",
                    Dimensions= "215x482x462mm",
                    MotherboardFormat= "ATX, microATX, extendedATX, ITX",
                    Color= "black",
                    Weight= "8kg",
                    IncludedFans= "3",
                    Price=585
                }
            };
        }
        public List<ComputerCase> GetComputerCases()
        {
            return _cases;
        }

        public ComputerCase RetrieveComputerCase(string id)
        {
            foreach(ComputerCase c in _cases)
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
