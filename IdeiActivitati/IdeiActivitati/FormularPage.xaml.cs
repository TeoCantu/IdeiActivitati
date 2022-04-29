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
    public partial class FormularPage : ContentPage
    {
        DaoActivitate daoActivitate;

        List<string> lista = new List<string>
        {
            TipActivitate.relaxation.ToString(),TipActivitate.recreational.ToString(),TipActivitate.charity.ToString(),
            TipActivitate.education.ToString(), TipActivitate.cooking.ToString(),TipActivitate.busywork.ToString(),
            TipActivitate.diy.ToString(), TipActivitate.music.ToString(),TipActivitate.social.ToString()
        };

        public string DescriereActivitate { get; set; }

        public string TipulActivitatii { get; set; }

        public int NrPersoane { get; set; }

        public double CostActivitate { get; set; }

        public DateTime DataActivitate { get; set; }
        public string DetaliiSuplimentareActivitate  { get; set; }
        public FormularPage()
        {
            InitializeComponent();
            BindingContext = this;
            pickerTipActivitate.ItemsSource = lista;
            daoActivitate = new DaoActivitate();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            
        }

        public void Adaugare_Clicked(object sender, EventArgs e)
        {
            Activitate activitate = new Activitate()
            {
                Descriere = DescriereActivitate,
                Tip = TipulActivitatii,
                Participanti = NrPersoane,
                Cost = CostActivitate,
                Data = DataActivitate,
                DetaliiSuplimentare = DetaliiSuplimentareActivitate
            };

            daoActivitate.AdaugaActivitate(activitate);
            Console.WriteLine("e ok doamne ajuta");
            DisplayAlert("Succes!", "Obiect adaugat", "OK");

        }
    }
}