using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IdeiActivitati
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AfisareActivitatePage : ContentPage
    {
        private string httpRequestUrl;
        private Activitate activitate;
        private DaoActivitate daoActivitate;

        public AfisareActivitatePage(string httpRequestUrl)
        {
            InitializeComponent();
            this.BindingContext = this;
            this.daoActivitate = new DaoActivitate();
            this.httpRequestUrl = httpRequestUrl;
            this.AfisareActivitate().GetAwaiter();
            this.loadingGrid.IsVisible = true;
        }

        public async Task AfisareActivitate()
        {
            try
            {
                var json = await new HttpClient().GetStringAsync(this.httpRequestUrl);
                if (json.Contains("error"))
                {
                    this.AfisareEroare();
                }
                else
                {
                    this.labelTitlu.Text = "Activitate nouă găsită!";
                    this.activitate = JsonConvert.DeserializeObject<Activitate>(json);
                    this.activitate.Data = DateTime.Now;

                    this.loadingGrid.IsVisible = false;

                    if (this.activitate != null)
                    {
                        this.TipLabel.Text = "Tip: " + activitate.Tip.ToString();
                        this.ActivitateLabel.Text = activitate.Descriere;
                        this.PretLabel.Text = "Cost: " + this.CostAfisat(this.activitate.Cost);
                        this.ParticipantiLabel.Text = "Participanți: " + activitate.Participanti.ToString();
                    }
                    else
                    {
                        this.AfisareEroare();
                    }
                }
            }
            catch
            {
                this.gridActivitate.IsVisible = false;
                this.loadingGrid.IsVisible = true;
            }
        }

        private void AfisareEroare()
        {
            this.labelTitlu.Text = "Ups..Nicio activitate nu corespunde filtrelor!";
            this.reincearcaButton.IsVisible = false;
            this.adaugaActivitateButton.IsVisible = false;
            this.activitateFrame.IsVisible = false;
            this.loadingGrid.IsVisible = false;
        }

        public string CostAfisat(double cost)
        {
            if (cost == 0.0)
            {
                return "gratuit";
            }
            else if (cost > 0.0 && cost <= 0.3)
            {
                return "redus";
            }
            else if (cost > 0.3 && cost <= 0.7)
            {
                return "mediu";
            }
            else
            {
                return "ridicat";
            }
        }

        private void schimbaFiltreButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private async void reincearcaButton_Clicked(object sender, EventArgs e)
        {
            await this.AfisareActivitate();
        }

        private void adaugaActivitateButton_Clicked(object sender, EventArgs e)
        {
            this.daoActivitate.AdaugaActivitate(this.activitate);
            Navigation.PushAsync(new ListaPage());
        }
    }
}