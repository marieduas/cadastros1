using Microsoft.Maui.Controls;

namespace cadastros
{
    public partial class Fornecedor: ContentPage
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void OnBuscarClicked(object sender, EventArgs e)
        {
            // Implementar lógica de busca
        }

        private void OnAdicionarClicked(object sender, EventArgs e)
        {
            // Implementar lógica de adicionar
        }

        private void OnRemoverClicked(object sender, EventArgs e)
        {
            // Implementar lógica de remover
        }

        private void OnRemoverItemClicked(object sender, EventArgs e)
        {
            // Implementar lógica de remover item específico
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Implementar lógica de voltar
        }
           public void botaovoltar(object sender, EventArgs args)
        {
                Application.Current.MainPage = new MainPage();
        }
              public void botaosalvar(object sender, EventArgs args)
        {
                Application.Current.MainPage = new MainPage();
        }
              public void botaocadastrar(object sender, EventArgs args)
        {
                Application.Current.MainPage = new CadastroFornecedor();
        }
    }
}
