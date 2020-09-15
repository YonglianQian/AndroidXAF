using Microsoft.AppCenter.Analytics;
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

            count++;
            ((Button)sender).Text = $"Version1: You clicked {count} times.";
        }
    }
}
