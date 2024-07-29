using System.Collections.ObjectModel;

namespace cadastros
{
    public partial class AtualizaFornecedor : ContentPage
    {
        public ObservableCollection<string> Names { get; set; }

        public AtualizaFornecedor()
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