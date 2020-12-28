using NuBank.Nubank;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NuBank.Apresentacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Slider3 : ContentPage
    {
        public Slider3()
        {
            InitializeComponent();
        }
        //PrincipalNubank

        public void PrincipalNubank(object sender, EventArgs args)
        {
            App.Current.MainPage = new NavigationPage(new PrincipalNubank());
        }
    }
}