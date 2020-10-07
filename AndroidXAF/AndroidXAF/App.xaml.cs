using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Distribute;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AndroidXAF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=7011b0df-8bdb-481d-97c0-ff484ec4284e;",
                  typeof(Analytics), typeof(Crashes), typeof(Distribute));
            AppCenter.LogLevel = LogLevel.Verbose;

            Distribute.CheckForUpdate();
        }
        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {

        }
    }
}
