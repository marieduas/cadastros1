using System.Collections.ObjectModel;

namespace cadastros
{
    public partial class Atualizarfornecedor : ContentPage
    {
        public ObservableCollection<string> Names { get; set; }

        public Atualizarfornecedor()
        {
            InitializeComponent();

            Names = new ObservableCollection<string>
            {
                "Luis",
                "Roberto",
                "Ana",
                "Julia"
            };
            BindingContext = this;
        }
    }
}