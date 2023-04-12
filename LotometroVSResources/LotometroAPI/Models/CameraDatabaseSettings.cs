using LotometroAPI.Interfaces;

namespace LotometroAPI.Models
{
    public class CameraDatabaseSettings : ICameraDatabaseSettings
    {
        public string CameraCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
