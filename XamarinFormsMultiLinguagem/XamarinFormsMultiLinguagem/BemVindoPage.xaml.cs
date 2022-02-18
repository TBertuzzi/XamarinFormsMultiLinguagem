using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsMultiLinguagem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BemVindoPage : ContentPage
    {
        public BemVindoPage()
        {
            InitializeComponent();
        }

        private void btnVoltarClick(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}