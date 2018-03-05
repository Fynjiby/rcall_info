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
        public DbSet<Gyro> Gyros { get; set; }
        public DbSet<Voltage> Voltages { get; set; }
        public DbSet<PDBType> PDBTypes { get; set; }
        public DbSet<BEC> BECs { get; set; }
        public DbSet<AccessoryType> AccessoryTypes { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<PullMeasurement> PullMeasurements { get; set; }
        public DbSet<PropType> PropTypes { get; set; }
        public DbSet<MotorKV> MotorKVs { get; set; }
        public DbSet<Current> Currents { get; set; }
        public DbSet<FirmwareModel> Firmware { get; set; }
        public DbSet<LinkType> LinkTypes { get; set; }
        public DbSet<Power> Powers { get; set; }
        public DbSet<AntennaConnector> AntennaConnector { get; set; }
        public DbSet<FOV> FOVs { get; set; }
        public DbSet<AspectRatio> AspectsRatio { get; set; }
        public DbSet<ImageSensor> ImageSensors { get; set; }
        public DbSet<HorizontalResolution> HorizontalResolutions { get; set; }
        public DbSet<Display> Displays { get; set; }
        public DbSet<Frequency> Frequency { get; set; }
        public DbSet<TransmitterType> TransmitterTypes { get; set; }
        public DbSet<RCProtocol> RCProtocols { get; set; }
        public DbSet<RCOtherType> RCOtherTypes { get; set; }
        public DbSet<BattaryType> BattaryTypes { get; set; }
        public DbSet<Capacity> Capacity { get; set; }
        public DbSet<DischargeRate> DischargeRates { get; set; }
        public DbSet<InstallDimension> InstallDimensions { get; set; }
        public DbSet<InstallDimensionMotor> InstallMotorDimensions { get; set; }
        public DbSet<Material> Materials { get; set; }
        public PartsContext(DbContextOptions<PartsContext> options)
            : base(options)
        {
        }
    }

}
