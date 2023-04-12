namespace LotometroAPI.Interfaces
{
    public interface ICameraService
    {
        public List<MonitoringItem> Get();

        public MonitoringItem Get(string id);

        public MonitoringItem Create(MonitoringItem book);

        public void Update(string id, MonitoringItem bookIn);

        public void Remove(MonitoringItem bookIn);

        public void Remove(string id);
    }

}
