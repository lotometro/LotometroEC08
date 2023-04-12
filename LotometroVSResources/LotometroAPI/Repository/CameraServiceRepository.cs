using LotometroAPI.Interfaces;
using MongoDB.Driver;

namespace LotometroAPI.Repository
{
    public class CameraServiceRepository : ICameraService
    {
        private readonly IMongoCollection<MonitoringItem> _monitoringItems;

        public CameraServiceRepository()
        {
            var client = new MongoClient("mongodb+srv://lotometroec08:lotometroec08@cluster0.ozbiz7i.mongodb.net/test?authSource=admin&replicaSet=atlas-4nfs83-shard-0&readPreference=primary&ssl=true");
            var database = client.GetDatabase("test_database");

            _monitoringItems = database.GetCollection<MonitoringItem>("camera_data");
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
