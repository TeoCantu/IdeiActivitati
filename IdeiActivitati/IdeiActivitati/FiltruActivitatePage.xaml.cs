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
    public partial class FiltruActivitatePage : ContentPage
    {
        private string[] tipuriActivitati;
        private int NumarParticipanti = 1;
        private string httpRequestUrl;

        public FiltruActivitatePage()
        {
            InitializeComponent();
            BindingContext = this;
            this.tipuriActivitati = Enum.GetNames(typeof(TipActivitate));
            this.tipPicker.ItemsSource = tipuriActivitati;
            this.ParticipantiLabel.Text = "Număr de participanți: " + this.NumarParticipanti.ToString();
        }

        private void GasesteButton_Clicked(object sender, EventArgs e)
        {
            this.GenereazaLink();

            Navigation.PushAsync(new AfisareActivitatePage(this.httpRequestUrl));
        }

        private void GenereazaLink()
        {
            this.httpRequestUrl = "http://www.boredapi.com/api/activity";

            this.httpRequestUrl += $"?participants={this.NumarParticipanti}";

            if (this.tipPicker.SelectedItem != null)
            {
                this.httpRequestUrl += $"&type={this.tipPicker.SelectedItem}";
            }

            if (this.CheckBox.IsChecked)
            {
                this.httpRequestUrl += "&price=0.0";
            }
        }

        private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.NumarParticipanti = Int32.Parse(e.NewValue.ToString());
            this.ParticipantiLabel.Text = "Număr de participanți: " + this.NumarParticipanti.ToString();
        }
    }
}