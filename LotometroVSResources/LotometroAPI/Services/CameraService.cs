using LotometroAPI.Interfaces;
using MongoDB.Driver;

namespace LotometroAPI.Services
{
    public class CameraService
    {
        private readonly IMongoCollection<MonitoringItem> _monitoringItems;

        public CameraService(ICameraDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _monitoringItems = database.GetCollection<MonitoringItem>(settings.CameraCollectionName);
        }

        public List<MonitoringItem> Get() =>
            _monitoringItems.Find(book => true).ToList();

        public MonitoringItem Get(string id) =>
            _monitoringItems.Find(book => book.descricaoDaCamera == id).FirstOrDefault();

        public MonitoringItem Create(MonitoringItem book)
        {
            _monitoringItems.InsertOne(book);
            return book;
        }

        public void Update(string id, MonitoringItem bookIn) =>
            _monitoringItems.ReplaceOne(book => book.descricaoDaCamera == id, bookIn);

        public void Remove(MonitoringItem bookIn) =>
            _monitoringItems.DeleteOne(book => book.descricaoDaCamera == bookIn.descricaoDaCamera);

        public void Remove(string id) =>
            _monitoringItems.DeleteOne(book => book.descricaoDaCamera == id);
    }

}
