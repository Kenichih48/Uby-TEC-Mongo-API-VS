using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace MongoExample.Models;

/// <summary>
/// Se preparan los espacios para guardar datos, en este caso strings, en el API y MongoDB
/// </summary>
public class Feedback {

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id {get; set;}

    //public string username {get; set;} = null!;
    public string compra {get; set;} = null!;
    public string afiliado {get; set;} = null!;
    
    public string repartidor {get; set;} = null!;

    //[BsonElement("items")]
    //[JsonPropertyName("items")]
    //public List<string> movieIds {get; set;} = null!;

    [BsonElement("feedback")]
    [JsonPropertyName("feedback")]
    public List<string> feedback {get; set;} = null!;



}