namespace Modelos
{

    public class Cliente : Pessoa
    {
        string Nome;
        string CPF;  
        string Endereço;
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

        public void SetCPF (string B)
        {
            this.CPF = B;
        }
        public string GetB ()
        {
            return CPF;
        }

        public void SetEndereço (string C)
        {
            this.Endereço = C;
        }
        public string GetC ()
        {
            return Endereço;
        }

        public void SetEmail (string D)
        {
            this.Email = D;
        }
        public string GetD ()
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