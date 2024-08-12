using LiteDB;

namespace Modelos;

public class Vendas
{
   public string produto { get; set; }
   public string quantidade { get; set; }
   public string lucro { get; set; }
   public string cliente { get; set; }
    [BsonId]
   public string Id { get; set; }

    
}