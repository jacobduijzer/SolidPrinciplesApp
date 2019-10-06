using System;
using Solid.SolidPrinciples;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Solid
{
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(ServiceProvider.GetService<PrinciplesView>());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
