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
    public partial class ListaTempo : ContentPage
    {
        public ListaTempo()
        {
            InitializeComponent();
        }

        private void VoltarTeste_Pressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void deztempos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}