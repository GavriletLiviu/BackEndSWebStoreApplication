using StoreBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GpusService
    {
        private List<Gpu> _gpus;
        public GpusService()
        {
            _gpus = new List<Gpu>()
            {
                new Gpu
                {
                   Id= "GPUASUSGEFORCERTX4090ROGSTRIXOC24GB",
                  Title= "Geforce 4090 Strix Oc",
                  Manufacturer= "Asus",
                  Slot= "Pci-Express 4.0x16",
                  Processor= "nVidia GeForce RTX 4090",
                  Cores= "18176",
                  Technologies= "GeForce ShadowPlay, NVIDIA ANSEL, DLSS, NVIDIA Gpu Boost",
                   Series= "GeForce RTX 4000",
                    ProcessorFrequency= "2610Mhz",
                   MemorySize= "24GB",
                   MemoryType= "GDDR6X",
                 MemoryBusSize= "384bits",
                   DirectX= "12 Ultimate",
                   OpenGl="4.2",
              DisplayPorts= "3x2.0",
               HdmiPorts= "1x2.1",
              VgaPorts= "0",
               DviPorts= "0",
               PowerPorts= "4x8pin",
               Power= "600W",
               Price= 13120
                },
                new Gpu
                {
                   Id= "GPUMSIGEFORCERTX4070VENTUS3X12GOC",
                  Title= "Geforce 4070 Ventus 3X",
                  Manufacturer= "Asus",
                  Slot= "Pci-Express 4.0x16",
                  Processor= "nVidia GeForce RTX 4070",
                  Cores= "18176",
                  Technologies= "GeForce ShadowPlay, NVIDIA ANSEL, DLSS, NVIDIA Gpu Boost",
                   Series= "GeForce RTX 4000",
                    ProcessorFrequency= "2610Mhz",
                   MemorySize= "12GB",
                   MemoryType= "GDDR6X",
                 MemoryBusSize= "384bits",
                   DirectX= "12 Ultimate",
                   OpenGl="4.2",
              DisplayPorts= "3x2.0",
               HdmiPorts= "1x2.1",
              VgaPorts= "0",
               DviPorts= "0",
               PowerPorts= "4x8pin",
               Power= "600W",
               Price= 13120
                },
                new Gpu
                {
                Id= "GPUASUSRADEON7900XTXTUFGAMING",
                Title= "Radeon RX 7900 XTX TUF GAming",
                Manufacturer= "Asus",
                Slot= "Pci-Express 4.0x16",
                Processor= "Navi 31 XTX",
                Cores= "6144",
                Technologies= "",
                Series= "Radeon RX 7000",
                ProcessorFrequency= "2615Mhz",
                MemorySize= "24GB",
                MemoryType= "GDDR6",
                MemoryBusSize= "384bits",
                DirectX= "12 Ultimate",
                OpenGl="4.2",
                DisplayPorts= "3x2.0",
                HdmiPorts= "1x2.1",
                VgaPorts= "0",
                DviPorts= "0",
                PowerPorts= "3x8pin",
                Power= "450W",
                Price= 7840
                },
                new Gpu
                {
                Id= "GPUGIGABYTERADEON7900XTXGAMINGOC",
                Title= "Radeon RX 7900 XTX Gaming OC",
                Manufacturer= "Gigabyte",
                Slot= "Pci-Express 4.0x16",
                Processor= "Navi 31 XTX",
                Cores= "6144",
                Technologies= "",
                Series= "Radeon RX 7000",
                ProcessorFrequency= "2525Mhz",
                MemorySize= "24GB",
                MemoryType= "GDDR6",
                MemoryBusSize= "384bits",
                DirectX= "12 Ultimate",
                OpenGl="4.2",
                DisplayPorts= "3x2.0",
                HdmiPorts= "1x2.1",
                VgaPorts= "0",
                DviPorts= "0",
                PowerPorts= "3x8pin",
                Power= "450W",
                Price= 5975
                },
                new Gpu
                {
                Id= "GPUASUSRADEON7900XTTUFGAMING",
                Title= "Radeon RX 7900 XT TUF GAming",
                Manufacturer= "Asus",
                Slot= "Pci-Express 4.0x16",
                Processor= "Navi 31 XT",
                Cores= "5376",
                Technologies= "",
                Series= "Radeon RX 7000",
                ProcessorFrequency= "2535Mhz",
                MemorySize= "20GB",
                MemoryType= "GDDR6",
                MemoryBusSize= "320bits",
                DirectX= "12 Ultimate",
                OpenGl="4.2",
                DisplayPorts= "3x2.0",
                HdmiPorts= "1x2.1",
                VgaPorts= "0",
                DviPorts= "0",
                PowerPorts= "3x8pin",
                Power= "450W",
                Price= 7561
                },
                new Gpu
                {
                Id= "GPUASUSRADEON7900XTGAMINGOC",
                Title= "Radeon RX 7900 XT Gaming OC",
                Manufacturer= "Gigabyte",
                Slot= "Pci-Express 4.0x16",
                Processor= "Navi 31 XT",
                Cores= "5376",
                Technologies= "",
                Series= "Radeon RX 7000",
                ProcessorFrequency= "2025Mhz",
                MemorySize= "20GB",
                MemoryType= "GDDR6",
                MemoryBusSize= "320bits",
                DirectX= "12 Ultimate",
                OpenGl="4.2",
                DisplayPorts= "3x2.0",
                HdmiPorts= "1x2.1",
                VgaPorts= "0",
                DviPorts= "0",
                PowerPorts= "3x8pin",
                Power= "450W",
                Price= 5603
                },
                new Gpu
                {
                Id= "GPURADEONRX7600DUALOC",
                Title= "Radeon RX 7600 Dual OC",
                Manufacturer= "Asus",
                Slot= "Pci-Express 4.0x16",
                Processor= "Navi 23",
                Cores= "2048",
                Technologies= "",
                Series= "Radeon RX 7000",
                ProcessorFrequency= "2725Mhz",
                MemorySize= "8GB",
                MemoryType= "GDDR6",
                MemoryBusSize= "128bits",
                DirectX= "12 Ultimate",
                OpenGl="4.2",
                DisplayPorts= "3x2.0",
                HdmiPorts= "1x2.1",
                VgaPorts= "0",
                DviPorts= "0",
                PowerPorts= "1x8pin",
                Power= "300W",
                Price= 1870
                },
                new Gpu
                {
                Id= "GPUGIGABYTERADEONRX7600GAMINGOC",
                Title= "Radeon RX 7600 Gaming OC",
                Manufacturer= "Gigabyte",
                Slot= "Pci-Express 4.0x16",
                Processor= "Navi 23",
                Cores= "2048",
                Technologies= "",
                Series= "Radeon RX 7000",
                ProcessorFrequency= "2755Mhz",
                MemorySize= "8GB",
                MemoryType= "GDDR6",
                MemoryBusSize= "128bits",
                DirectX= "12 Ultimate",
                OpenGl="4.2",
                DisplayPorts= "3x2.0",
                HdmiPorts= "1x2.1",
                VgaPorts= "0",
                DviPorts= "0",
                PowerPorts= "1x8pin",
                Power= "300W",
                Price= 1670
                },
                new Gpu
                {
                Id= "GPUASUSRADEON7900XT",
                Title= "Radeon RX 7900 XT",
                Manufacturer= "Asus",
                Slot= "Pci-Express 4.0x16",
                Processor= "Navi 31 XT",
                Cores= "5376",
                Technologies= "",
                Series= "Radeon RX 7000",
                ProcessorFrequency= "2025Mhz",
                MemorySize= "20GB",
                MemoryType= "GDDR6",
                MemoryBusSize= "320bits",
                DirectX= "12 Ultimate",
                OpenGl="4.2",
                DisplayPorts= "3x2.0",
                HdmiPorts= "1x2.1",
                VgaPorts= "0",
                DviPorts= "0",
                PowerPorts= "3x8pin",
                Power= "450W",
                Price= 5899
                },
                new Gpu
                {
                Id= "GPUGIGABYTERADEON7900XTXELITE",
                Title= "Radeon RX 7900 XTX Elite",
                Manufacturer= "Gigabyte",
                Slot= "Pci-Express 4.0x16",
                Processor= "Navi 31 XTX",
                Cores= "6144",
                Technologies= "",
                Series= "Radeon RX 7000",
                ProcessorFrequency= "2680Mhz",
                MemorySize= "24GB",
                MemoryType= "GDDR6",
                MemoryBusSize= "384bits",
                DirectX= "12 Ultimate",
                OpenGl="4.2",
                DisplayPorts= "3x2.0",
                HdmiPorts= "1x2.1",
                VgaPorts= "0",
                DviPorts= "0",
                PowerPorts= "3x8pin",
                Power= "450W",
                Price= 7105
                }
            };
        }
        public List<Gpu> GetGpus()
        {
            return _gpus;
        }

        public Gpu RetrieveGpu(string id)
        {
            foreach (Gpu c in _gpus)
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
