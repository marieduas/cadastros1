using Microsoft.Maui.Controls;
using Modelos;

namespace cadastros;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}

        public void botaocliente(object sender, EventArgs args)
        {
                Application.Current.MainPage = new BuscarCliente();
        }
	 public void botaofornecedor(object sender, EventArgs args)
        {
                Application.Current.MainPage = new BuscarFornecedor();
        }
        public void botaomateria(object sender, EventArgs args)
        {
                Application.Current.MainPage = new BuscarMateriaPrima();
        }
         public void botaotransportadora(object sender, EventArgs args)
        {
               // Application.Current.MainPage = new Transportadora();
        }
         public void botaoproduto(object sender, EventArgs args)
        {
                Application.Current.MainPage = new BuscarProduto();
        }
}