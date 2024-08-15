using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace cadastros
{
    public partial class Produto : ContentPage
    {
        public ObservableCollection<Product> Products { get; set; }

        public Produto()
        {
            InitializeComponent();
            
            Products = new ObservableCollection<Product>
            {
                new Product { Name = "algodão" },
                new Product { Name = "aba" },
                new Product { Name = "botão" },
                new Product { Name = "plástico" },
                new Product { Name = "linha" }
            };
            ProductListView.ItemsSource = Products;
        }

        private void OnSearchClicked(object sender, EventArgs e)
        {
            // Lógica para buscar produtos
            string searchText = ProductSearchEntry.Text;
            // Filtrar a lista de produtos com base no texto de pesquisa
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            // Lógica para adicionar um novo produto
        }

        private void OnRemoveClicked(object sender, EventArgs e)
        {
            // Lógica para remover um produto
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            // Lógica para deletar o produto da lista
            var button = sender as Button;
            var product = button.BindingContext as Product;
            Products.Remove(product);
        }

        private void OnBackClicked(object sender, EventArgs e)
        {
            // Lógica para voltar para a página anterior
            Navigation.PopAsync();
        }
    }

    public class Product
    {
        public string Name { get; set; }
    }
}
