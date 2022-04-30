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
            // MainPage = new DesprePage();
            MainPage = new NavigationPage(new MainPage());
            // MainPage = new NavigationPage(new FiltruActivitatePage());
           // MainPage = new AppShell();
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
