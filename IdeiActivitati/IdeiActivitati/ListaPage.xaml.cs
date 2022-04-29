using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IdeiActivitati
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaPage : ContentPage
    {
        DaoActivitate daoActivitate;
        List<Activitate> listaActivitati = new List<Activitate>();
        public ListaPage()
        {
            InitializeComponent();
            daoActivitate = new DaoActivitate();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listaActivitati = daoActivitate.ObtineToateInregistrarile();
            listviewActivitate.ItemsSource = listaActivitati;
        }
    }
}