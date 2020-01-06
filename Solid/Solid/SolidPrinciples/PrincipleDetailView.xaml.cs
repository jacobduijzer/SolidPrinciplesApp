using Xam.Forms.Markdown;
using Xamarin.Forms;

namespace Solid.SolidPrinciples
{
    public partial class PrincipleDetailView : ContentPage
    {
        public PrincipleDetailView(PrincipleDetailViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;

            markdownView.Theme = new DarkMarkdownTheme();
        }
    }
}
