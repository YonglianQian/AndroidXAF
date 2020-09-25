using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AndroidXAF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        int count = 0;
        void Button_Clicked(object sender, System.EventArgs e)
        {
            Analytics.TrackEvent("Button is clicked at " + DateTime.Now.ToLongTimeString());

            try
            {
                throw new Exception("a test exception");
            }
            catch (Exception exception)
            {
                Crashes.TrackError(exception);
            }

            count++;
            ((Button)sender).Text = $"Version5: You clicked {count} times.";
        }
    }
}
