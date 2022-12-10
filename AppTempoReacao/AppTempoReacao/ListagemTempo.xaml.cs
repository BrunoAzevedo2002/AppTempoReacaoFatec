using AppTempoReacao.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTempoReacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tempos : ContentPage
    {
        public Tempos()
        {
            InitializeComponent();
        }

        private void lst_tempo_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        protected override void OnAppearing()
        {
            ObservableCollection<Model.Tempos> lista_tempos = new ObservableCollection<Model.Tempos>();

            System.Threading.Tasks.Task.Run(async () =>
            {
                List<Model.Tempos> temp = await App.Database.GetAll();

                foreach (Model.Tempos item in temp)
                { 
                    lista_tempos.Add(item);
                }

            });

            lst_tempo.ItemsSource = lista_tempos;
        }

    }
}