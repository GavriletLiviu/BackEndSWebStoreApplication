using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using StoreBackEnd.Entities;
using Services.Entities;

namespace Bachelor.Entities
{
    public class ComponentsDbContext : DbContext
    {
        public ComponentsDbContext(DbContextOptions options) : base(options) { }
        public DbSet<ComputerCase> Cases { get; set; }
        public DbSet<Cpu> Cpus { get; set; }
        public DbSet<Cpufan> Cpufans { get; set; }
        public DbSet<Cpufanliquid> Cpufansliquid { get; set; }
        public DbSet<Drive> Drives { get; set; }
        public DbSet<Fan> Fans { get; set; }
        public DbSet<Gpu> Gpus { get; set; }
        public DbSet<Headphones> Headphones { get; set; }
        public DbSet<Keyboard> Keyboards { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<Mouse> Mice { get; set; }
        public DbSet<Power> Powers { get; set; }
        public DbSet<Ram> Rams { get; set; }
        public DbSet<Speakers> Speakers { get; set; }
        public DbSet<Ssd> Ssds { get; set; }
        public DbSet<RegisterUser> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ComputerCase>().ToTable("Cases");
            modelBuilder.Entity<Cpu>().ToTable("Cpus");
            modelBuilder.Entity<Cpufan>().ToTable("Cpufans");
            modelBuilder.Entity<Cpufanliquid>().ToTable("Cpufansliquid");
            modelBuilder.Entity<Drive>().ToTable("Drives");
            modelBuilder.Entity<Fan>().ToTable("Fans");
            modelBuilder.Entity<Gpu>().ToTable("Gpus");
            modelBuilder.Entity<Headphones>().ToTable("Headphones");
            modelBuilder.Entity<Keyboard>().ToTable("Keyboards");
            modelBuilder.Entity<Screen>().ToTable("Screens");
            modelBuilder.Entity<Motherboard>().ToTable("Motherboards");
            modelBuilder.Entity<Mouse>().ToTable("Mice");
            modelBuilder.Entity<Power>().ToTable("Powers");
            modelBuilder.Entity<Ram>().ToTable("Rams");
            modelBuilder.Entity<Speakers>().ToTable("Speakers");
            modelBuilder.Entity<Ssd>().ToTable("Ssds");
            modelBuilder.Entity<RegisterUser>().ToTable("Users");


            string casesJson = System.IO.File.ReadAllText("cases.json");
            List<ComputerCase> cases = System.Text.Json.JsonSerializer.Deserialize<List<ComputerCase>>(casesJson);
            foreach (ComputerCase Case in cases)
            {
                modelBuilder.Entity<ComputerCase>().HasData(Case);
            }

            string cpuJson = System.IO.File.ReadAllText("cpus.json");
            List<Cpu> cpus = System.Text.Json.JsonSerializer.Deserialize<List<Cpu>>(cpuJson);
            foreach (Cpu cpu in cpus)
            {
                modelBuilder.Entity<Cpu>().HasData(cpu);
            }

            string cpufanJson = System.IO.File.ReadAllText("cpufans.json");
            List<Cpufan> cpufans = System.Text.Json.JsonSerializer.Deserialize<List< Cpufan>>(cpufanJson);
            foreach (Cpufan cpufan in cpufans)
            {
                modelBuilder.Entity<Cpufan>().HasData(cpufan);
            }

            string cpufanliquidJson = System.IO.File.ReadAllText("cpufansliquid.json");
            List<Cpufanliquid> cpufansliquid = System.Text.Json.JsonSerializer.Deserialize<List<Cpufanliquid>>(cpufanliquidJson);
            foreach (Cpufanliquid cpufanliquid in cpufansliquid)
            {
                modelBuilder.Entity<Cpufanliquid>().HasData(cpufanliquid);
            }

            string driveJson = System.IO.File.ReadAllText("drives.json");
            List<Drive> drives = System.Text.Json.JsonSerializer.Deserialize<List<Drive>>(driveJson);
            foreach (Drive drive in drives)
            {
                modelBuilder.Entity<Drive>().HasData(drive);
            }

            string fanJson = System.IO.File.ReadAllText("fans.json");
            List<Fan> fans = System.Text.Json.JsonSerializer.Deserialize<List<Fan>>(fanJson);
            foreach (Fan fan in fans)
            {
                modelBuilder.Entity<Fan>().HasData(fan);
            }

            string gpuJson = System.IO.File.ReadAllText("gpus.json");
            List<Gpu> gpus = System.Text.Json.JsonSerializer.Deserialize<List<Gpu>>(gpuJson);
            foreach (Gpu gpu in gpus)
            {
                modelBuilder.Entity<Gpu>().HasData(gpu);
            }

            string headphonesJson = System.IO.File.ReadAllText("headphones.json");
            List<Headphones> headphones = System.Text.Json.JsonSerializer.Deserialize<List<Headphones>>(headphonesJson);
            foreach (Headphones headphone in headphones)
            {
                modelBuilder.Entity<Headphones>().HasData(headphone);
            }

            string keyboardJson = System.IO.File.ReadAllText("keyboards.json");
            List<Keyboard> keyboards = System.Text.Json.JsonSerializer.Deserialize<List<Keyboard>>(keyboardJson);
            foreach (Keyboard keyboard in keyboards)
            {
                modelBuilder.Entity<Keyboard>().HasData(keyboard);
            }

            string motherboardJson = System.IO.File.ReadAllText("motherboards.json");
            List<Motherboard> motherboards = System.Text.Json.JsonSerializer.Deserialize<List<Motherboard>>(motherboardJson);
            foreach (Motherboard motherboard in motherboards)
            {
                modelBuilder.Entity<Motherboard>().HasData(motherboard);
            }

            string mouseJson = System.IO.File.ReadAllText("mice.json");
            List<Mouse> mice = System.Text.Json.JsonSerializer.Deserialize<List<Mouse>>(mouseJson);
            foreach (Mouse mouse in mice)
            {
                modelBuilder.Entity<Mouse>().HasData(mouse);
            }

            string powerJson = System.IO.File.ReadAllText("powers.json");
            List<Power> powers = System.Text.Json.JsonSerializer.Deserialize<List<Power>>(powerJson);
            foreach (Power power in powers)
            {
                modelBuilder.Entity<Power>().HasData(power);
            }

            string ramJson = System.IO.File.ReadAllText("rams.json");
            List<Ram> rams = System.Text.Json.JsonSerializer.Deserialize<List<Ram>>(ramJson);
            foreach (Ram ram in rams)
            {
                modelBuilder.Entity<Ram>().HasData(ram);
            }

            string screenJson = System.IO.File.ReadAllText("screens.json");
            List<Screen> screens = System.Text.Json.JsonSerializer.Deserialize<List<Screen>>(screenJson);
            foreach (Screen screen in screens)
            {
                modelBuilder.Entity<Screen>().HasData(screen);
            }

            string speakersJson = System.IO.File.ReadAllText("speakers.json");
            List<Speakers> speakers = System.Text.Json.JsonSerializer.Deserialize<List<Speakers>>(speakersJson);
            foreach (Speakers speaker in speakers)
            {
                modelBuilder.Entity<Speakers>().HasData(speaker);
            }

            string ssdJson = System.IO.File.ReadAllText("ssds.json");
            List<Ssd> ssds = System.Text.Json.JsonSerializer.Deserialize<List<Ssd>>(ssdJson);
            foreach (Ssd ssd in ssds)
            {
                modelBuilder.Entity<Ssd>().HasData(ssd);
            }
        }
    }
}
