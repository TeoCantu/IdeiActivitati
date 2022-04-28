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
        }
    }
}
