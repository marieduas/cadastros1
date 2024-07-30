namespace Modelos
{

    public class Fornecedor : Pessoa
    {
        string Nome;
        string CPFCNPJ;
        string Endereço;
        int Número;
        string Cidade;
        string Estado;
        string Pais;
        string CEP;
        int Telefone;
        string Email;
        int id;

        public void SetNome (string A)
        {
            this.Nome = A;
        }
        public string GetA ()
        {
            return Nome;
        }

        public void SetCPFCNPJ (string B)
        {
            this.CPFCNPJ = B;
        }
        public string GetB ()
        {
            return CPFCNPJ;
        }

        public void SetEndereço (string C)
        {
            this.Endereço = C;
        }
        public string GetC ()
        {
            return Endereço;
        }

        public void SetNúmero (int D)
        {
            this.Número = D;
        } 
        public int GetD ()
        {
            return Número;
        }

        public void SetCidade (string E)
        {
            this.Cidade = E;
        }
        public string GetE ()
        {
            return Cidade;
        }

        public void SetEstado (string F)
        {
            this.Estado = F;
        }
        public string GetF ()
        {
            return Estado;
        }

        public void SetPais (string G)
        {
            this.Pais = G;
        }
        public string GetG ()
        {
            return Pais;
        }

        public void SetCEP (string H)
        {
            this.CEP = H;
        }
        public string GetH ()
        {
            return CEP;
        }

        public void SetTelefone (int I)
        {
            this.Telefone = I;
        }
        public int GetI ()
        {
            return Telefone;
        }

        public void SetEmail (string J)
        {
            this.Email = J;
        }
        public string GetJ ()
        {
            return Email;
        }

         public void Setid (int id)
        {
            this.id = id;
        }
        public int Getid ()
        {
            return id;
        }
    }
}