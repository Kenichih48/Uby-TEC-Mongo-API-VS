namespace MongoExample.Models;

/// <summary>
/// Se preparan 3 espacios para los parametros utilizados en luego en el json de los appsettings
/// </summary>
public class MongoDBSettings {

    public string ConnectionURI {get; set;} = null!;
    public string DatabaseName {get; set;} = null!;
    public string CollectionName {get; set;} = null!;


}