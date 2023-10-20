using Bachelor.Entities;
using StoreBackEnd.Entities;

namespace Services
{
    public class CpusService
    {
        private List<Cpu> _cpus;
        public CpusService()
        {
            _cpus = new List<Cpu>()
            {
                new Cpu 
                {
                    Id="MBAMDR97950X",
                    Manufacturer="amd",
                    Title="7950x",
                    Family="Ryzen9",
                    Socket="am5",
                    BaseFrequency="4200mhz",
                    BoostFrequency="5700mhz",
                    Cores="16",
                    CacheL1="16000kb",
                    CacheL3="128mb",
                    Tdp="120w",
                    Price=5073,
                },
                new Cpu
                {
                    Id="MBAMDR97950X3D",
                    Manufacturer="amd",
                    Title="7950x3d",
                    Family="Ryzen9",
                    Socket="am5",
                    BaseFrequency="4200mhz",
                    BoostFrequency="5700mhz",
                    Cores="16",
                    CacheL1="16000kb",
                    CacheL3="128mb",
                    Tdp="120w",
                    Price=4209,
                },
                new Cpu
                {
                    Id="MBAMDR97900X",
                    Manufacturer="amd",
                    Title="7900X",
                    Family="Ryzen9",
                    Socket="am5",
                    BaseFrequency="4700mhz",
                    BoostFrequency="5600mhz",
                    Cores="12",
                    CacheL1="768kb",
                    CacheL3="64mb",
                    Tdp="170w",
                    Price=2325,
                },
                new Cpu
                {
                    Id="MBAMDR97900",
                    Manufacturer="amd",
                    Title="7900",
                    Family="Ryzen9",
                    Socket="am5",
                    BaseFrequency="3700mhz",
                    BoostFrequency="5400mhz",
                    Cores="12",
                    CacheL1="768kb",
                    CacheL3="64mb",
                    Tdp="65w",
                    Price=2020,
                },
                new Cpu
                {
                    Id="MBAMDR77800X3D",
                    Manufacturer="amd",
                    Title="7800X3D",
                    Family="Ryzen7",
                    Socket="am5",
                    BaseFrequency="4200mhz",
                    BoostFrequency="5000mhz",
                    Cores="8",
                    CacheL1="512kb",
                    CacheL3="96mb",
                    Tdp="65w",
                    Price=2350,
                },
                new Cpu
                {
                    Id="MBAMDR77700",
                    Manufacturer="amd",
                    Title="7700",
                    Family="Ryzen7",
                    Socket="am5",
                    BaseFrequency="3800mhz",
                    BoostFrequency="5300mhz",
                    Cores="8",
                    CacheL1="512kb",
                    CacheL3="32mb",
                    Tdp="65w",
                    Price=1650,
                },
                new Cpu
                {
                    Id="MBAMDR34300G",
                    Manufacturer="amd",
                    Title="4300G",
                    Family="Ryzen3",
                    Socket="am4",
                    BaseFrequency="3800mhz",
                    BoostFrequency="4000mhz",
                    Cores="4",
                    CacheL1="256kb",
                    CacheL3="4mb",
                    Tdp="65w",
                    Price=440,
                },
                new Cpu
                {
                    Id="MBAMDI913900K",
                    Manufacturer="intel",
                    Title="13900k",
                    Family="core i9",
                    Socket="1700",
                    BaseFrequency="3000mhz",
                    BoostFrequency="5800mhz",
                    Cores="24",
                    CacheL1="4kb",
                    CacheL3="32mb",
                    Tdp="250w",
                    Price=3150,
                },
                new Cpu
                {
                    Id="MBAMDI913900",
                    Manufacturer="intel",
                    Title="13900",
                    Family="core i9",
                    Socket="1700",
                    BaseFrequency="2000mhz",
                    BoostFrequency="5600mhz",
                    Cores="24",
                    CacheL1="4kb",
                    CacheL3="32mb",
                    Tdp="125w",
                    Price=3182,
                },
                new Cpu
                {
                    Id="MBAMDI913900F",
                    Manufacturer="intel",
                    Title="13900F",
                    Family="core i9",
                    Socket="1700",
                    BaseFrequency="2000mhz",
                    BoostFrequency="5600mhz",
                    Cores="24",
                    CacheL1="4kb",
                    CacheL3="32mb",
                    Tdp="65w",
                    Price=3042,
                },
                new Cpu
                {
                    Id="MBAMDI713700K",
                    Manufacturer="intel",
                    Title="13700K",
                    Family="core i7",
                    Socket="1700",
                    BaseFrequency="3400mhz",
                    BoostFrequency="5400mhz",
                    Cores="16",
                    CacheL1="4kb",
                    CacheL3="24mb",
                    Tdp="125w",
                    Price=2260,
                },
                new Cpu
                {
                    Id="MBAMDI713700",
                    Manufacturer="intel",
                    Title="13700",
                    Family="core i7",
                    Socket="1700",
                    BaseFrequency="2100mhz",
                    BoostFrequency="5200mhz",
                    Cores="16",
                    CacheL1="4kb",
                    CacheL3="24mb",
                    Tdp="65w",
                    Price=2162,
                },
                new Cpu
                {
                    Id="MBAMDI713700KF",
                    Manufacturer="intel",
                    Title="13700KF",
                    Family="core i7",
                    Socket="1700",
                    BaseFrequency="3400mhz",
                    BoostFrequency="5400mhz",
                    Cores="16",
                    CacheL1="4kb",
                    CacheL3="24mb",
                    Tdp="125w",
                    Price=2120,
                },
                new Cpu
                {
                    Id="MBAMDI713700F",
                    Manufacturer="intel",
                    Title="13700F",
                    Family="core i7",
                    Socket="1700",
                    BaseFrequency="2100mhz",
                    BoostFrequency="5200mhz",
                    Cores="16",
                    CacheL1="4kb",
                    CacheL3="24mb",
                    Tdp="65w",
                    Price=2020,
                },
                new Cpu
                {
                    Id="MBAMDI513600K",
                    Manufacturer="intel",
                    Title="13600K",
                    Family="core i5",
                    Socket="1700",
                    BaseFrequency="3500mhz",
                    BoostFrequency="5100mhz",
                    Cores="14",
                    CacheL1="2048kb",
                    CacheL3="24mb",
                    Tdp="125w",
                    Price=1720,
                },
                new Cpu
                {
                    Id="MBAMDI513500",
                    Manufacturer="intel",
                    Title="13500",
                    Family="core i5",
                    Socket="1700",
                    BaseFrequency="2500mhz",
                    BoostFrequency="4800mhz",
                    Cores="14",
                    CacheL1="2048kb",
                    CacheL3="24mb",
                    Tdp="65w",
                    Price=1344,
                },
                new Cpu
                {
                    Id="MBAMDI513400",
                    Manufacturer="intel",
                    Title="13400",
                    Family="core i5",
                    Socket="1700",
                    BaseFrequency="2500mhz",
                    BoostFrequency="4600mhz",
                    Cores="10",
                    CacheL1="2048kb",
                    CacheL3="20mb",
                    Tdp="65w",
                    Price=1282,
                },
                new Cpu
                {
                    Id="MBAMDI313100",
                    Manufacturer="intel",
                    Title="13100",
                    Family="core i3",
                    Socket="1700",
                    BaseFrequency="3400mhz",
                    BoostFrequency="4500mhz",
                    Cores="4",
                    CacheL1="2048kb",
                    CacheL3="12mb",
                    Tdp="58w",
                    Price=801,
                }
            };
        }
        public List<Cpu> GetCpus()
        {
            return _cpus;
        }

        public Cpu RetrieveCpu(string id)
        {
            foreach (Cpu c in _cpus)
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