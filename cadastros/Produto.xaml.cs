namespace cadastros
{
    public partial class Produto: ContentPage
    {
        public Produto()
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
               public void botaocadastrar(object sender, EventArgs args)
        {
                Application.Current.MainPage = new CadastroProduto();
        }
    }
  

}