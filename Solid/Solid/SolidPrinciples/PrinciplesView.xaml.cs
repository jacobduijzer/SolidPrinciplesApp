using Solid.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Solid.SolidPrinciples
{
    public partial class PrinciplesView : ContentPage
    {
        private readonly PrinciplesViewModel _viewModel;

        public PrinciplesView(PrinciplesViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = _viewModel = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_viewModel.Items.Count == 0)
                _viewModel.LoadItemsCommand.Execute(null);
        }

        public async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (!(args.SelectedItem is Principle principle))
                return;

            await Navigation.PushAsync(new PrincipleDetailView(new PrincipleDetailViewModel(principle)));
            ItemsListView.SelectedItem = null;
        }
    }
}
