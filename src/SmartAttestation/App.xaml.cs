using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SmartAttestation.Services;
using SmartAttestation.Views;

namespace SmartAttestation
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            DependencyService.Register<MockAttestationDataStore>();           
            MainPage = new MainPage();
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
