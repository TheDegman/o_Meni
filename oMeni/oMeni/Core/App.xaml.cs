using System;
using oMeni.Core;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace oMeni
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Core.AppShell();
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
