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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button_LoginClicked(object sender, EventArgs e)
        {
            string UsuarioEntry = txtUsuarioEntry.Text;
            string SenhaEntry = txtSenhaEntry.Text;

            if (UsuarioEntry == "Kevedo" && SenhaEntry == "123")
            {
                await DisplayAlert("Bem Vindo!", "Logado com sucesso!", "CONTINUAR");
                await Navigation.PushAsync(new ListaTempo());
            }
            else
            {
                await DisplayAlert("Oh, não!", "Usuário ou senha incorretos!", "CORRIGIR");
            }
        }

        private async void ButtonRegistro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistroPage());
        }

    }
}


