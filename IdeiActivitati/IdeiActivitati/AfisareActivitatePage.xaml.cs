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

        public AfisareActivitatePage(string httpRequestUrl)
        {
            InitializeComponent();
            BindingContext = this;
            this.httpRequestUrl = httpRequestUrl;
            AfisareActivitate().GetAwaiter();
        }

        public async Task AfisareActivitate()
        {
            var json = await new HttpClient().GetStringAsync(this.httpRequestUrl);

            if (json.Contains("error"))
            {
                this.gridActivitate.IsVisible = false;
                this.eroareGrid.IsVisible = true;
            }
            else
            {
                this.activitate = JsonConvert.DeserializeObject<Activitate>(json);

                if (this.activitate != null)
                {
                    this.TipLabel.Text = "Tip: " + activitate.Tip.ToString();
                    this.ActivitateLabel.Text = activitate.Descriere;
                    this.PretLabel.Text = "Cost: " + activitate.Cost.ToString();
                    this.ParticipantiLabel.Text = "Participanți: " + activitate.Participanti.ToString();
                }

                this.gridActivitate.IsVisible = true;
                this.eroareGrid.IsVisible = false;
            }
        }
    }
}