using AppTempoReacao.Helper;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTempoReacao
{
    public partial class App : Application
    {

        static AppDataHelper database;

        public static AppDataHelper Database
        {
            get
            {
                if (database == null)
                {
                    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"arquivo.db3");
                    database = new AppDataHelper(path);
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new MainPage());
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
