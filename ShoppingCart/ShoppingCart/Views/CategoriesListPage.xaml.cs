using ShoppingCart.ViewModels;
using Xamarin.Forms;

namespace ShoppingCart.Views
{
    public partial class CategoriesListPage
    {
        public CategoriesListPage()
        {
            InitializeComponent();
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var param = e.SelectedItem as string;
            var command = ((CategoriesListViewModel)BindingContext).NavigateToCategory;

            if (command.CanExecute(param))
            {
                command.Execute(param);
            }
        }
    }
}