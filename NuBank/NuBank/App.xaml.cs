using NuBank.Apresentacao;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NuBank
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Intro();
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
