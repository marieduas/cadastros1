namespace cadastros
{
    public partial class MateriaPrima: ContentPage
    {
        public MateriaPrima()
        {
            InitializeComponent();
        }
         public void botaovoltar(object sender, EventArgs args)
        {
                Application.Current.MainPage = new MainPage();
        }
              public void botaosalvar(object sender, EventArgs args)
        {
                Application.Current.MainPage = new MainPage();
        }
    }
         private async void botaosalvar(object sender, EventArgs e)
    {
        if (await VerificaSeDadosEstaoCorretos()) // Verifica se os dados são válidos antes de salvar no banco
        {
        // O código abaixo preenche o objeto Materia Prima (Modelo) com os dados das Entry's
        var Materia Prima = new Modelos.MateriaPrima();
        if (!String.IsNullOrEmpty(IdLabel.Text))
            Materia Prima.Id      = int.Parse(IdLabel.Text);
        else
            Materia Prima.Id      = 0;
        Materia Prima.Nome      = NomeEntry.Text;
        Materia Prima.Sobrenome = SobrenomeEntry.Text;
        Materia Prima.Telefone  = TelefoneEntry.Text;

        // Com o objeto preenchido enviamos para o controle para criar/atualizar no Banco de Dados
        Materia PrimaControle.CriarOuAtualizar(Materia Prima);
        // Mostra a mensagem de sucesso
        await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
        }
    }

}