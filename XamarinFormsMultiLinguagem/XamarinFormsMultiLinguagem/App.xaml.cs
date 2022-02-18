using System;
using System.Globalization;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsMultiLinguagem
{
    public partial class App : Application
    {
        public App()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
