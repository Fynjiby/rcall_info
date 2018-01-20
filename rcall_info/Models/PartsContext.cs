using Microsoft.EntityFrameworkCore;

namespace fpv_info.Models
{
    public class PartsContext : DbContext
    {
        public DbSet<AccessoryModel> Accessories { get; set; }
        public DbSet<Antenna> Antennas { get; set; }
        public DbSet<Battery> Batteries { get; set; }
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Charger> Chargers { get; set; }
        public DbSet<ESC> ESCs { get; set; }
        public DbSet<FileModel> Files { get; set; }
        public DbSet<Frame> Frames { get; set; }
        public DbSet<FrameType> FrameTypes { get; set; }
        public DbSet<Fuselage> Fuselages { get; set; }
        public DbSet<FuselageType> FuselageTypes { get; set; }
        public DbSet<Goggle> Goggles { get; set; }
        public DbSet<Light> Lights { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<ProcessorModel> Processors { get; set; }
        public DbSet<Prop> Props { get; set; }
        public DbSet<RCOther> RCOthers { get; set; }
        public DbSet<Receiver> Receivers { get; set; }
        public DbSet<Servo> Servos { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Transmitter> Transmitters { get; set; }
        public DbSet<VideoReceiver> VideoReceivers { get; set; }
        public DbSet<VideoTransmitter> VideoTransmitters { get; set; }
        public DbSet<FlightController> FlightControllers { get; set; }
        public DbSet<PDB> PDBs { get; set; }
        public DbSet<Motor> Motors { get; set; }
        public PartsContext(DbContextOptions<PartsContext> options)
            : base(options)
        {
        }
    }

}
