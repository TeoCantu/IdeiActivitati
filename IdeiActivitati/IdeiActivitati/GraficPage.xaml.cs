using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IdeiActivitati
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GraficPage : ContentPage
    {
        List<Activitate> listaActivitati;
        DaoActivitate daoActivitate;
        public GraficPage()
        {
            InitializeComponent();
            daoActivitate = new DaoActivitate();

            List<string> listaDate = new List<string>();
            listaDate.Add("Cost - Tip");
            listaDate.Add("Cost - Data");
            listaDate.Add("Numar - Tip");

            List<string> listaTipuri = new List<string> { "BarChart", "PieChart", "RadarChart", "RadialGauge" };
            pickerDateGrafic.ItemsSource = listaDate;

            pickerTipGrafic.ItemsSource = listaTipuri;
        
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.listaActivitati = daoActivitate.ObtineToateInregistrarile();
        }

        private List<ChartEntry> costData()
        {
            List<ChartEntry> listaGrafic = new List<ChartEntry>();
            var rand = new Random();

            foreach (Activitate activitate in listaActivitati)
            {
                listaGrafic.Add(new ChartEntry((float)activitate.Cost)
                {
                    Label = activitate.Data.ToString("dd.MM.yyyy"),
                    ValueLabel = activitate.Cost.ToString(),
                    Color = new SKColor((byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255))
                });
            }

            return listaGrafic;
        }

        private List<ChartEntry> costTip()
        {
            List<ChartEntry> listaGrafic = new List<ChartEntry>();
            var rand = new Random();
            Dictionary<string, float> dictCosturi = new Dictionary<string, float>();
            dictCosturi.Add("charity", 0);
            dictCosturi.Add("recreational", 0);
            dictCosturi.Add("education", 0);
            dictCosturi.Add("social", 0);
            dictCosturi.Add("cooking", 0);
            dictCosturi.Add("music", 0);
            dictCosturi.Add("busywork", 0);
            dictCosturi.Add("diy", 0);
           
            foreach(Activitate activitate in listaActivitati)
            {
                switch (activitate.Tip)
                {
                    case "charity":
                        dictCosturi["charity"] += (float)activitate.Cost;
                        break;
                    case "recreational":
                        dictCosturi["recreational"] += (float)activitate.Cost;
                        break ;
                    case "education":
                        dictCosturi["education"]+=(float)activitate.Cost;  
                        break;
                    case "social":
                        dictCosturi["social"]+=(float)activitate.Cost;
                        break;
                    case "cooking":
                        dictCosturi["cooking"]+=(float)activitate.Cost;
                        break;
                    case "relaxation":
                        dictCosturi["relaxation"]+=(float)activitate.Cost;
                        break;
                    case "music":
                        dictCosturi["music"]+=(float)activitate.Cost;
                        break;
                    case "diy":
                        dictCosturi["diy"]+=(float)activitate.Cost;
                        break;
                    case "busywork":
                        dictCosturi["busywork"]+=(float)activitate.Cost;
                        break;
                }
            }
            foreach (string tip in dictCosturi.Keys)
            {
                listaGrafic.Add(new ChartEntry(dictCosturi[tip])
                {
                    Label = tip,
                    ValueLabel = dictCosturi[tip].ToString(),
                    Color = new SKColor((byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255))
                });
            }

            return listaGrafic;
        }

        private List<ChartEntry> numarTip()
        {
            var rand = new Random();
            Dictionary<string, int> dictCosturi = new Dictionary<string, int>();
            dictCosturi.Add("charity", 0);
            dictCosturi.Add("recreational", 0);
            dictCosturi.Add("education", 0);
            dictCosturi.Add("social", 0);
            dictCosturi.Add("cooking", 0);
            dictCosturi.Add("music", 0);
            dictCosturi.Add("busywork", 0);
            dictCosturi.Add("diy", 0);

            List<ChartEntry> listaGrafic = new List<ChartEntry>();

            foreach(Activitate activitate in listaActivitati)
            {
                switch (activitate.Tip)
                {
                    case "charity":
                        dictCosturi["charity"] ++;
                        break;
                    case "recreational":
                        dictCosturi["recreational"] ++;
                        break;
                    case "education":
                        dictCosturi["education"] ++;
                        break;
                    case "social":
                        dictCosturi["social"] ++;
                        break;
                    case "cooking":
                        dictCosturi["cooking"] ++;
                        break;
                    case "relaxation":
                        dictCosturi["relaxation"] ++;
                        break;
                    case "music":
                        dictCosturi["music"] ++;
                        break;
                    case "diy":
                        dictCosturi["diy"] ++;
                        break;
                    case "busywork":
                        dictCosturi["busywork"] ++;
                        break;
                }
            }

            foreach (string tip in dictCosturi.Keys)
            {
                listaGrafic.Add(new ChartEntry(dictCosturi[tip])
                {
                    Label = tip,
                    ValueLabel = dictCosturi[tip].ToString(),
                    Color = new SKColor((byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255))
                });
            }

            return listaGrafic;
        }

        private async void buttonAfiseaza_Clicked(object sender, EventArgs e)
        {
            string tipGrafic = null;
            string dateGrafic = null;

            if(pickerDateGrafic.SelectedItem == null)
            {
                await DisplayAlert("Atentie", "Alege datele pentru grafic", "OK");
                
            } else
            {
                dateGrafic = pickerDateGrafic.SelectedItem.ToString();
                if (pickerTipGrafic.SelectedItem == null)
                {
                    await DisplayAlert("Atentie", "Alege tipul pentru grafic", "OK");
                    
                }
                else
                {
                    tipGrafic = pickerTipGrafic.SelectedItem.ToString();
                    switch (tipGrafic)
                    {
                        case "RadarChart":
                            chartActivitate.Chart = new RadarChart();
                            break;
                        case "BarChart":
                            chartActivitate.Chart = new BarChart();
                            break;
                        case "PieChart":
                            chartActivitate.Chart = new PieChart();
                            break;
                        case "RadialGauge":
                            chartActivitate.Chart = new RadialGaugeChart();
                            break;
                    }

                    switch (dateGrafic)
                    {
                        case "Cost - Data":
                            chartActivitate.Chart.Entries = costData().ToArray();
                            break;
                        case "Cost - Tip":
                            chartActivitate.Chart.Entries = costTip().ToArray();
                            break;
                        case "Numar - Tip":
                            chartActivitate.Chart.Entries = numarTip().ToArray();
                            break;
                        default:
                            chartActivitate.Chart.Entries = costData().ToArray();
                            break;
                    }
                }
            }   
        }          
    }
}