using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class MonitoringItem
{
    [BsonId]
    public ObjectId Id { get; set; }
    public string Name { get; set; }
    public int Qtd { get; set; }
}