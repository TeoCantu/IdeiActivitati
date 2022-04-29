using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IdeiActivitati
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // aici am pus asa ca sa testez pagina
            //MainPage = new MainPage();
            MainPage = new NavigationPage(new FiltruActivitatePage());
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
