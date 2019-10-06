using Xamarin.Forms;

namespace Solid.SolidPrinciples
{
    public partial class PrincipleDetailView : ContentPage
    {
        public PrincipleDetailView(PrincipleDetailViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
