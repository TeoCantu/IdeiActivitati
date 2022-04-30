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
            this.ParticipantiLabel.Text = "Participanți: " + this.NumarParticipanti.ToString();
        }

        private void GasesteButton_Clicked(object sender, EventArgs e)
        {
            this.GenereazaLink();

            Navigation.PushAsync(new AfisareActivitatePage(this.httpRequestUrl));
        }

        private void GenereazaLink()
        {
            this.httpRequestUrl = "http://www.boredapi.com/api/activity";
            var isFirstParameter = true;

            if (CheckBoxParticipanti.IsChecked)
            {
                if (isFirstParameter)
                {
                    this.httpRequestUrl += $"?participants={this.NumarParticipanti}";
                    isFirstParameter = false;
                }
                else
                {
                    this.httpRequestUrl += $"&participants={this.NumarParticipanti}";
                }
            }

            if (this.tipPicker.SelectedItem != null)
            {
                if (isFirstParameter)
                {
                    this.httpRequestUrl += $"?type={this.tipPicker.SelectedItem}";
                    isFirstParameter = false;
                }
                else
                {
                    this.httpRequestUrl += $"&type={this.tipPicker.SelectedItem}";
                }
            }

            if (this.GratuitCheckBox.IsChecked)
            {

                if (isFirstParameter)
                {
                    this.httpRequestUrl += "?price=0.0";
                    isFirstParameter = false;
                }
                else
                {
                    this.httpRequestUrl += "&price=0.0";
                }
            }
        }

        private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.NumarParticipanti = Int32.Parse(e.NewValue.ToString());
            this.ParticipantiLabel.Text = "Participanți: " + this.NumarParticipanti.ToString();
        }

        private void CheckBoxParticipanti_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                this.ParticipantiLabel.IsVisible = true;
                this.stepper.IsVisible = true;
            }
            else
            {
                this.ParticipantiLabel.IsVisible = false;
                this.stepper.IsVisible = false;
            }
        }
    }
}