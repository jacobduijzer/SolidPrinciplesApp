using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Solid.Helpers;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Crashes;

namespace Solid.Droid
{
    [Activity(Label = "Solid", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.SetFlags("CollectionView_Experimental");
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            AppCenter.Start("ae4014f8-d674-49dd-88af-4d7fb4692403", typeof(Analytics), typeof(Crashes));

            LoadApplication(Startup.Init(ConfigureServices));
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void ConfigureServices(HostBuilderContext ctx, IServiceCollection services) =>
           services.AddSingleton<INativeCalls, NativeCalls>();
    }

    public class NativeCalls : INativeCalls
    {
        public void OpenToast(string text) =>
            Toast.MakeText(Application.Context, text, ToastLength.Long).Show();
    }
}