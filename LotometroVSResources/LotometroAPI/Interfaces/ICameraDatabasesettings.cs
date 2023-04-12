namespace LotometroAPI.Interfaces
{
    public interface ICameraDatabaseSettings
    {
        string CameraCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
