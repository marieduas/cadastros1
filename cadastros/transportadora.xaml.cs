using Microsoft.Maui.Controls;

namespace cadastros
{
    public partial class transportadora : ContentPage
    {
        public transportadora()
        {
            InitializeComponent();
           // var rest = Awaint DisplayAlert ("tir","msg","botão 1","botâo?");
           //IF (rest =="botão1")
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