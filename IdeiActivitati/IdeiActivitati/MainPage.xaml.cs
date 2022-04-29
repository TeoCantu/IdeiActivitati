using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IdeiActivitati
{
    public partial class MainPage : ContentPage
    {
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
    }
}
