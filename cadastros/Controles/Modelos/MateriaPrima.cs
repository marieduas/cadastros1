namespace Modelos
{
    public class MateriaPrima : Registro
    {
        int Unidade;
        string ValorEstimado;
        string TempoEstimado;
        string PreçoTotal;
        int id;

        public void SetUnidade (int A)
        {
            this.Unidade = A;
        }
        public int GetA ()
        {
            return Unidade;
        }

        public void SetValorEstimado (string B)
        {
            this.ValorEstimado = B;
        }
        public string GetB ()
        {
            return ValorEstimado;
        }

        public void SetTempoEstimado (string C)
        {
            this.TempoEstimado = C;
        }
        public string GetC ()
        {
            return TempoEstimado;
        }

        public void SetPreçoTotal (string D)
        {
            this.PreçoTotal = D;
        }
        public string GetD ()
        {
            return PreçoTotal;
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