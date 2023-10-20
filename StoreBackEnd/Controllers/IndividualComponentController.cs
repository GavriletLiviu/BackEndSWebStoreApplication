using Bachelor.Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Threading;

namespace StoreBackEnd.Controllers
{
    public class IndividualComponentController : Controller
    {
        private readonly ComputerCaseService _computercaseService;
        private readonly CpufansliquidService _cpufansliquidService;
        private readonly CpufansService _cpufansService;
        private readonly CpusService _cpusService;
        private readonly DrivesService _drivesService;
        private readonly FansService _fansService;
        private readonly GpusService _gpusService;
        private readonly HeadphonesService _headphonesService;
        private readonly KeyboardsService _keyboardsService;
        private readonly MiceService _miceService;
        private readonly MotherboardsService _motherboardsService;
        private readonly PowersService _powersService;
        private readonly RamsService _ramsService;
        private readonly ScreensService _screensService;
        private readonly SpeakersService _speakersService;
        private readonly ComponentsDbContext _dbContext;
        private readonly SsdsService _ssdsService;

        public IndividualComponentController(ComponentsDbContext dbContext)
        {
            _computercaseService = new ComputerCaseService();
            _cpufansliquidService = new CpufansliquidService();
            _cpufansService = new CpufansService();
            _cpusService = new CpusService();
            _drivesService = new DrivesService();
            _fansService = new FansService();
            _gpusService = new GpusService();
            _headphonesService = new HeadphonesService();
            _keyboardsService = new KeyboardsService();
            _miceService = new MiceService();
            _motherboardsService = new MotherboardsService();
            _powersService = new PowersService();
            _ramsService = new RamsService();
            _screensService = new ScreensService();
            _speakersService = new SpeakersService();
            _ssdsService = new SsdsService();
            _dbContext = dbContext;
        }
        [Route("/computercase/{caseId}")]
        [HttpGet]
        public IActionResult Cases(string caseId)
        {
            var computercase = _computercaseService.RetrieveComputerCase(caseId);
            return Ok(computercase);
        }

        [Route("/cpu/{cpuId}")]
        [HttpGet]
        public IActionResult Cpu(string cpuId)
        {
            var cpu = _cpusService.RetrieveCpu(cpuId);
            return Ok(cpu);
        }

        [Route("/cpufan/{cpufanId}")]
        [HttpGet]
        public IActionResult CpuFan(string cpufanId)
        {
            var cpufan = _cpufansService.RetrieveCpufan(cpufanId);
            return Ok(cpufan);
        }

        [Route("/cpufanliquid/{cpufanliquidId}")]
        [HttpGet]
        public IActionResult CpuFanLiquid(string cpufanliquidId)
        {
            var cpufanliquid = _cpufansliquidService.RetrieveCpufanliquid(cpufanliquidId);
            return Ok(cpufanliquid);
        }

        [Route("/drive/{driveId}")]
        [HttpGet]
        public IActionResult Drive(string driveId)
        {
            var drive = _drivesService.RetrieveDrives(driveId);
            return Ok(drive);
        }

        [Route("/fan/{fanId}")]
        [HttpGet]
        public IActionResult Fan(string fanId)
        {
            var fan = _fansService.RetrieveFan(fanId);
            return Ok(fan);
        }

        [Route("/gpu/{gpuId}")]
        [HttpGet]
        public IActionResult Gpu(string gpuId)
        {
            var gpu = _gpusService.RetrieveGpu(gpuId);
            return Ok(gpu);
        }

        [Route("/headphones/{headphonesId}")]
        [HttpGet]
        public IActionResult Headphones(string headphonesId)
        {
            var headphones = _headphonesService.RetrieveHeadphones(headphonesId);
            return Ok(headphones);
        }

        [Route("/keyboard/{keyboardId}")]
        [HttpGet]
        public IActionResult Keyboard(string keyboardId)
        {
            var keyboard = _keyboardsService.RetrieveKeyboards(keyboardId);
            return Ok(keyboard);
        }

        [Route("/monitor/{monitorId}")]
        [HttpGet]
        public IActionResult Monitor(string monitorId)
        {
            var screen = _screensService.RetrieveScreens(monitorId);
            return Ok(screen);
        }

        [Route("/motherboard/{motherboardId}")]
        [HttpGet]
        public IActionResult Motherboard(string motherboardId)
        {
            var motherboard = _motherboardsService.RetrieveMotherboards(motherboardId);
            return Ok(motherboard);
        }

        [Route("/mouse/{mouseId}")]
        [HttpGet]
        public IActionResult Mouse(string mouseId)
        {
            var mouse = _miceService.RetrieveMice(mouseId);
            return Ok(mouse);
        }

        [Route("/power/{powerId}")]
        [HttpGet]
        public IActionResult Power(string powerId)
        {
            var power = _powersService.RetrievePowers(powerId);
            return Ok(power);
        }

        [Route("/ram/{ramId}")]
        [HttpGet]
        public IActionResult Ram(string ramId)
        {
            var ram = _ramsService.RetrieveRams(ramId);
            return Ok(ram);
        }

        [Route("/speakers/{speakersId}")]
        [HttpGet]
        public IActionResult Speakers(string speakersId)
        {
            var speakers = _speakersService.RetrieveSpeakers(speakersId);
            return Ok(speakers);
        }

        [Route("/ssd/{ssdId}")]
        [HttpGet]
        public IActionResult Ssd(string ssdId)
        {
            var ssd = _ssdsService.RetrieveSsd(ssdId);
            return Ok(ssd);
        }
    }
}
