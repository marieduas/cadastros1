namespace cadastros
{
    public partial class BuscarMateriaPrima: ContentPage
    {
        public BuscarMateriaPrima()
        {
            InitializeComponent();
        }
         public void botaovoltar(object sender, EventArgs args)
        {
                Application.Current.MainPage = new MainPage();
        }
    }
}