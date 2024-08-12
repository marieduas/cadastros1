
using Modelos;

namespace Controles;

public class TransportadorControle : BaseControle
{
  //----------------------------------------------------------------------------

  public TransportadoraControle() : base()
  {
    NomeDaTabela = "Transportadora";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idTransportadora)
  {
    var collection = liteDB.GetCollection<Transportadora>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idTransportadora);
  }

  //----------------------------------------------------------------------------

  public virtual List<Transportadora>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Transportadora>(NomeDaTabela);
    return new List<Transportadora>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idTransportadora)
  {
    var collection = liteDB.GetCollection<Transportadora>(NomeDaTabela);
    collection.Delete(idTransportadora);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Transporatdora Transporatdora)
  {
    var collection = liteDB.GetCollection<Transportadora>(NomeDaTabela);
    collection.Upsert(Transporatdora);
  }

  //----------------------------------------------------------------------------
}