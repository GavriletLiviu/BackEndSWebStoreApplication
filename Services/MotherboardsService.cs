using StoreBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MotherboardsService
    {
        private List<Motherboard> _motherboards;
        public MotherboardsService()
        {
            _motherboards = new List<Motherboard>()
            {
                new Motherboard
                {
                    Id= "MBOASUSROGCROSSHAIRX670EEXTREME",
                  Title= "Rog Crosshair x670E",
                  Manufacturer= "Asus",
                  CpuSocket= "am5",
                  Chipset= "AMD X670",
                  SupportedCpu= "AMD Ryzen 7000 Series",
                  MemoryType= "DDR5",
                  MemoryCapacity= "128GB",
                  MemorySlots= "4",
                   PcieVersion= "PCIe 5.0",
                   AudioCodec= "Realtek + ESS",
                   Lan= "Marvell AQtion 10Gb + Intel 2.5Gb",
                   Connectivity= "5xAudio, Optical Out, clear CMOS, Wi-fi, 2xRj-45, 1xUsb3.2gen2x2, Bios FlashBack, 9xUsb3.2gen2, 2xUsb4.0",
                   RaidVersions= "0,1,10",
                   SataInterfaces= "6xSATA III",
                   PcieFullSlots= "2",
                   PcieSlots= "1",
                   M2Slots= "5",
                   Technologies= "Asus Q-Design, DualBIOS, ROG Extreme OC Kit, AURA Sync, Wi-fi 6E",
                  Dimensions= "30.5x27.7cm",
                  Price= 6308
                },
                new Motherboard
                {
              Id= "MBOMSIMEGX670EGODLIKE",
                  Title= "Meg X670E Godlike",
                  Manufacturer= "Asus",
                  CpuSocket= "am5",
                  Chipset= "AMD X670",
                  SupportedCpu= "AMD Ryzen 7000 Series",
                  MemoryType= "DDR5",
                  MemoryCapacity= "128GB",
                  MemorySlots= "4",
                   PcieVersion= "PCIe 5.0",
                   AudioCodec= "Realtek + ESS",
                   Lan= "Marvell AQtion 10Gb + Intel 2.5Gb",
                   Connectivity= "5xAudio, Optical Out, clear CMOS, Wi-fi, 2xRj-45, 1xUsb3.2gen2x2, Bios FlashBack, 9xUsb3.2gen2, 2xUsb4.0",
                   RaidVersions= "0,1,10",
                   SataInterfaces= "6xSATA III",
                   PcieFullSlots= "2",
                   PcieSlots= "1",
                   M2Slots= "5",
                   Technologies= "Asus Q-Design, DualBIOS, ROG Extreme OC Kit, AURA Sync, Wi-fi 6E",
                  Dimensions= "30.5x27.7cm",
                  Price= 8370
                }
            };
        }
        public List<Motherboard> GetMotherboards()
        {
            return _motherboards;
        }

        public Motherboard RetrieveMotherboards(string id)
        {
            foreach (Motherboard c in _motherboards)
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
