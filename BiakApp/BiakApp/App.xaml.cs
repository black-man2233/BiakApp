using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BiakApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StartUp();
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
