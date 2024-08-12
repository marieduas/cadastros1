using LiteDB;

namespace Modelos
{
    public class Produto : Registro
    {
       public int Unidade{ get; set; }
       public  string ValorEstimado{ get; set; }
       public string TempoEstimado{ get; set; }
       public string PreçoTotal{ get; set; }
       [BsonId]
       public int Id{ get; set; }
    }
}