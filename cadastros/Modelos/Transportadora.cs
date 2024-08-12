using LiteDB;

namespace Modelos
{
    public class Transportadora : Registro
    {
        public string Nome { get; set; }
        public string CPFCNPJ { get; set; }
        public string Endereço { get; set; }
        public int Número { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public  string Pais { get; set; }
        public string CEP { get; set; }
        public  int Telefone { get; set; }
        public  string Email { get; set; }
        public string Percurso { get; set; }
        [BsonId]
        public int Id { get; set; }

       
    }
}