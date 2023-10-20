using Bachelor.Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Entities;

namespace StoreBackEnd.Controllers
{
    public class CategoriesController : Controller
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
        private readonly SsdsService _ssdsService;

        public CategoriesController(ComponentsDbContext dbContext)
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

        private readonly ComponentsDbContext _dbContext;
        [Route("/")]
        public IActionResult Index()
        {
            return Content("Backend is online!");
        }

        [Route("/computercase")]
        [HttpGet]
        public IActionResult ComputerCase()
        {
            List<ComputerCase> compcases = _computercaseService.GetComputerCases();
            return Ok(compcases);
        }

        [Route("/cpu")]
        [HttpGet]
        public IActionResult Cpu()
        {
            var cpus = _cpusService.GetCpus();
            return Ok(cpus);
        }

        [Route("/cpufan")]
        [HttpGet]
        public IActionResult CpuFan()
        {
            var cpufans = _cpufansService.GetCpuFans();
            return Ok(cpufans);
        }

        [Route("/cpufanliquid")]
        [HttpGet]
        public IActionResult CpuFanLiquid()
        {
            var cpufansliquid = _cpufansliquidService.GetCpuFansLiquid();
            return Ok(cpufansliquid);
        }

        [Route("/drive")]
        [HttpGet]
        public IActionResult Drive()
        {
            var drives = _drivesService.GetDrives();
            return Ok(drives);
        }

        [Route("/fan")]
        [HttpGet]
        public IActionResult Fan()
        {
            var fans = _fansService.GetFans();
            return Ok(fans);
        }

        [Route("/Gpu")]
        [HttpGet]
        public IActionResult Gpu()
        {
            var gpus = _gpusService.GetGpus();
            return Ok(gpus);
        }

        [Route("/headphones")]
        [HttpGet]
        public IActionResult Headphones()
        {
            var headphones = _headphonesService.GetHeadphones();
            return Ok(headphones);
        }

        [Route("/keyboard")]
        [HttpGet]
        public IActionResult Keyboard()
        {
            var keyboards = _keyboardsService.GetKeyboards();
            return Ok(keyboards);
        }

        [Route("/monitor")]
        [HttpGet]
        public IActionResult Monitor()
        {
            var monitors = _screensService.GetScreens();
            return Ok(monitors);
        }

        [Route("/motherboard")]
        [HttpGet]
        public IActionResult Motherboard()
        {
            var motherboards = _motherboardsService.GetMotherboards();
            return Ok(motherboards);
        }

        [Route("/mouse")]
        [HttpGet]
        public IActionResult Mouse()
        {
            var mice = _miceService.GetMice();
            return Ok(mice);
        }

        [Route("/power")]
        [HttpGet]
        public IActionResult Power()
        {
            var powers = _powersService.GetPowers();
            return Ok(powers);
        }

        [Route("/ram")]
        [HttpGet]
        public IActionResult Ram()
        {
            var rams = _ramsService.GetRams();
            return Ok(rams);
        }

        [Route("/speakers")]
        [HttpGet]
        public IActionResult Speakers()
        {
            var speakers = _speakersService.GetSpeakers();
            return Ok(speakers);
        }

        [Route("/ssd")]
        [HttpGet]
        public IActionResult Ssds()
        {
            var ssds = _ssdsService.GetSsds();
            return Ok(ssds);
        }
    }
}
