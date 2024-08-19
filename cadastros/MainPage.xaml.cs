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
                Application.Current.MainPage = new Cliente();
        }
	 public void botaofornecedor(object sender, EventArgs args)
        {
                Application.Current.MainPage = new Fornecedor();
        }
        public void botaomateria(object sender, EventArgs args)
        {
                Application.Current.MainPage = new MateriaPrima();
        }
         public void botaotransportadora(object sender, EventArgs args)
        {
               Application.Current.MainPage = new transportadora();
        }
         public void botaoproduto(object sender, EventArgs args)
        {
                Application.Current.MainPage = new Produto();
        }
}