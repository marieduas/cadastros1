using Microsoft.Maui.Controls;

namespace cadastros
{
    public partial class Cadastrotransportadora : ContentPage
    {
        public Cadastrotransportadora()
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