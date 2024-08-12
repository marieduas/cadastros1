
using Modelos;

namespace Controles;

public class FornecedorControle : BaseControle
{
  //----------------------------------------------------------------------------

  public FornecedorControle() : base()
  {
    NomeDaTabela = "Clientes";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCliente)
  {
    var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual List<Cliente>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Cliente>(NomeDaTabela);
    return new List<Cliente>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idFornecedor)
  {
    var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
    collection.Delete(idFornecedor);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Cliente Fornecedor)
  {
    var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
    collection.Upsert(Fornecedor);
  }

  //----------------------------------------------------------------------------
}