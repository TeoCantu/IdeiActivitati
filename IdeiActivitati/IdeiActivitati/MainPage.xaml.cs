using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IdeiActivitati
{
    public partial class MainPage : ContentPage
    {
        List<Activitate> listaActivitati = new List<Activitate>();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void Formular_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync( new FormularPage() );
        }

        private void Lista_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaPage());
        }

        private void Filtru_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FiltruActivitatePage());
        }

        private void Grafic_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GraficPage());
        }

        private void Despre_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DesprePage());
        }

        private void Sugestii_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SugestiiPage());
        }


    }
}
