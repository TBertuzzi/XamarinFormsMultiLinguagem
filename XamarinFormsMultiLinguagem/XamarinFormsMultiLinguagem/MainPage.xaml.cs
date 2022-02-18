using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFormsMultiLinguagem.Resources;

namespace XamarinFormsMultiLinguagem
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void AlterarLinguagem(string linguagem)
        {
            var language = new CultureInfo(linguagem);
            Thread.CurrentThread.CurrentUICulture = language;
            AppResources.Culture = language;
        }

        public async void btnInglesClickedAsync(object sender, System.EventArgs e)
        {

            AlterarLinguagem("en-US");
            await Navigation.PushAsync(new BemVindoPage());

        }

        public async void btnPortuguesClickedAsync(object sender, System.EventArgs e)
        {

            AlterarLinguagem("pt-BR");
            await Navigation.PushAsync(new BemVindoPage());

        }

        public async void btnJaponesClickedAsync(object sender, System.EventArgs e)
        {

            AlterarLinguagem("ja-JP");
            await Navigation.PushAsync(new BemVindoPage());

        }
    }
}
