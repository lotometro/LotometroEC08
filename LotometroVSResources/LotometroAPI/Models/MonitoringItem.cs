using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class MonitoringItem
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public int id_local { get; set; }
    public int id_camera { get; set; }
    public string descricaoDoLocal { get; set; }
    public string descricaoDaCamera { get; set; }
    public int numeroPessoas { get; set; }
    public int percentualDeLotacao { get; set; }
    public DateTime dataInformacao { get; set; }

    //public string Id { get; set; }
    //public string Name { get; set; }
    //public int Qtd { get; set; }


}