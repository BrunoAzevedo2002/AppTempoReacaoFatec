using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTempoReacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroPage : ContentPage
    {
        public RegistroPage()
        {
            InitializeComponent();
        }

        private async void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            string NovoUsuarioEntry = txtNovoUsuarioEntry.Text;
            string NovoEmailEntry = txtNovoEmailEntry.Text;
            string NovaSenhaEntry = txtNovaSenhaEntry.Text;
            string ConfirmaSenhaEntry = txtConfirmaSenhaEntry.Text;

            if (NovoUsuarioEntry == "Kevedo"  && NovoEmailEntry == "kevedo@gmail.com"  && NovaSenhaEntry == "123"  && ConfirmaSenhaEntry == "123")
            {
                await DisplayAlert("Bem Vindo!", "Registrado com sucesso!", "LOGIN");
                await Navigation.PushAsync(new LoginPage());
            }
            else
            {

                await DisplayAlert("Ops, algo errado!", "Campos não preenchidos!", "CORRIGIR");
            }
        }

        private async void ButtonRegistroLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}