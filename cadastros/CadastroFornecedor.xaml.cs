using Microsoft.Maui.Controls;

namespace cadastros
{
    public partial class CadastroFornecedor : ContentPage
    {
        public CadastroFornecedor()
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
}