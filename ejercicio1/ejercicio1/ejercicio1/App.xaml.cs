using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ejercicio1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            //cuando la applicación inicia
        }

        protected override void OnSleep()
        {
            //cuando la applicación está en segundo plano
        }

        protected override void OnResume()
        {
            //cuando está en segundo plano y se vuelve activar
        }
    }
}
