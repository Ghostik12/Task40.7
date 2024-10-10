using PhotoGalery.Pages;
using PhotoGalery.Services;
using PhotoGalery.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhotoGalery
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new PineCodePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
