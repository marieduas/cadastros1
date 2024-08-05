using System.Collections.ObjectModel;

namespace cadastros
{
    public partial class Atualizafornecedor : ContentPage
    {
        public ObservableCollection<string> Names { get; set; }

        public Atualizafornecedor()
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