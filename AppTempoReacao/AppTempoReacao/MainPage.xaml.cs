using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using Xamarin.Forms;

namespace AppTempoReacao
{
    public partial class MainPage : ContentPage
    {

        int button_count = 0;
        
        Stopwatch stopwatch = new Stopwatch();


        public MainPage()
        {
            InitializeComponent();
        }



        private async void BotaoReacao_Pressed(object sender, EventArgs e)
        {
            button_count++;

            if (button_count == 1)
            {
                BotaoReacao.Text = "Espere...";

                Random aleatorio = new Random();
                int tempo = aleatorio.Next(1000, 10000);
                await Task.Delay(tempo);


                BotaoReacao.IsEnabled = true;
                BotaoReacao.BackgroundColor = Color.Lime;
                BotaoReacao.Text = "AGORA!";
                stopwatch.Start();
            }


            else if (button_count == 2)
            {
                stopwatch.Stop();
                int tempo_decorrido = (int)stopwatch.ElapsedMilliseconds;
                string resultado = Convert.ToString(tempo_decorrido);
                PreTempoReacao.Text = "Seu tempo de reação foi de:";
                TempoReacao.Text = resultado + "ms";
                button_count = 0;
                stopwatch.Reset();
                BotaoReacao.Text = "Clique!";
                BotaoReacao.BackgroundColor = Color.Red;
                button_count = 0;

                await App.Database.Insert(new Model.Tempos
                {
                    Tempo = resultado,
                    Data = DateTime.Now,
                }) ;
            }
        }

        private async void SalvarTempo_Pressed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
