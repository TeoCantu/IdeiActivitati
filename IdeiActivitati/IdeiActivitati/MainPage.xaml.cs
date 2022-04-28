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

            listaActivitati.Add(new Activitate(1, "Prima activitate", "recreational", 1, 0, DateTime.Now, null));
            listaActivitati.Add(new Activitate(2, "Voluntariat", "charity", 10, 0, DateTime.ParseExact("01.03.2022", "dd.MM.yyyy", CultureInfo.InvariantCulture), null));
            listaActivitati.Add(new Activitate(3, "Am ajutat o batranica", "charity", 1, 200, DateTime.ParseExact("08.03.2022", "dd.MM.yyyy", CultureInfo.InvariantCulture), null));
            listaActivitati.Add(new Activitate(4, "Plimbare in Herastrau", "recreational", 2, 3, DateTime.ParseExact("01.04.2022", "dd.MM.yyyy", CultureInfo.InvariantCulture), null));
            listaActivitati.Add(new Activitate(5, "Am citit", "recreational", 1, 0, DateTime.ParseExact("20.04.2022", "dd.MM.yyyy", CultureInfo.InvariantCulture), "Am citit cartea Mandrie si prejudecata de Jane Austen."));

            
        }
    }
}
