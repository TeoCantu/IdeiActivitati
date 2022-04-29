using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IdeiActivitati
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SugestiiPage : ContentPage
    {
        public List<Sugestie> ListaSugestii { get; set; } = new List<Sugestie>();
       
        public List<string> TipuriSugestii { get; set; } = new List<string>();
        public SugestiiPage()
        {
            InitializeComponent();
            TipuriSugestii.Add("Filme");
            TipuriSugestii.Add("Carti");
            pickerTipActivitate.ItemsSource = TipuriSugestii;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }

        private List<Sugestie> SugestiiFilme()
        {
            List<Sugestie> lista = new List<Sugestie>();
            lista.Add(new Sugestie
            {
                Denumire = "Choose or die",

                Imagine = "https://dnm.nflximg.net/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABTLjoxSnud-PECgpNIZIWlBmgm0HK2ocoBmhWw8hL2DnDjbK0ep5anctYTonRNxzzQVag7TqGsGulD-lbUVnL8zvMJ-QC6TuIHwk8g9wXJEP9FayEEfJQvg56SQFeA.jpg?r=8d0",

                Descriere = "Netflix top 10"
            });

            lista.Add(new Sugestie
            {
                Denumire = "The in between",

                Imagine = "https://dnm.nflximg.net/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABZX7O_kAccEVTx5cqMFdsa8cwvyyeS5FgpLehuAqcbnfmmHnkMJzCJaE575n3Y8weF2w7hlfFHWA1EJmQbJJr_0JpgrTYIWcljchS7Eyoh5RYizLlvPfmM_L9wilFQ.jpg?r=848",

                Descriere = "Netflix top 10"
            });

            lista.Add(new Sugestie
            {
                Denumire = "White hot",
                Imagine = "https://dnm.nflximg.net/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABd4lgQ_1RlKR1RdKzR4taActrJuO40O-HiWcFbpdiQulmOJ5f62ZxssCcKCjX49cn3n6k0Spk472Uf8pR-jKbKsZNWWFoTF5Gb_9t0oAAPCv2sXVT7-IsbnkEMTIeg.jpg?r=d90",
                Descriere = "Netflix top 10"
            });
           
            lista.Add(new Sugestie
            {
                Denumire = "How it ends",
                Imagine = "https://dnm.nflximg.net/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABRLfzcSHHslmcwR4oQPGGz2XfKH0HCZ7gLZh0nOv-4W5zBCT_RLjy_hlFjrIqXRgcvMxjgd_LV8DvFqKggdS-dga7xeWdGujw8pys7CYeguM2C60BKY2VBmiJkMhjw.jpg?r=921",
                Descriere = "Netflix top 10"
            });

            lista.Add(new Sugestie
            {
                Denumire = "Yakuza princess",
                Imagine = "https://dnm.nflximg.net/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABUKxLEcV381DWpPYqCPPaXbB9Xb0sNvQWTBFALXCGjK0phrWr-5Dhu5TZbGu3GjwiT4HGi8y1C-ThXS1EAv5Ff1-5xfE5XYWBVKCt6JPff5UdoYxTED1ZSMZKlg6vg.jpg?r=a39",
                Descriere = "Netflix top 10"
            });

            lista.Add(new Sugestie
            {
                Denumire = "The Adam Project",
                Imagine = "https://dnm.nflximg.net/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABVi07erihcYzF5tEDSAMtg9nsFAV3qX6BmOyuYODr5569Ym2ZezmcKYN0YY2ODXs_ZjQiL8PjCCKZSVmKCnefDW4EOEbFbj1L9zcfH-ZKN2Z7LQYpuWHFlgeTGofHg.jpg?r=3db",
                Descriere = "Netflix top 10"
            });

            lista.Add(new Sugestie
            {
                Denumire = "Playing with fire",
                Imagine = "https://dnm.nflximg.net/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABfeBKWeUNhAIfKvU3dK_Ec8rj7GOP3S0G3Wug4Zuu-rw0_J1ZLVHe2bJtpdatnMCbXZfCRzFeueDG7Vk06fleMhjfpbL.jpg?r=b7b",
                Descriere = "Netflix top 10"
            });
            
            lista.Add(new Sugestie
            {
                Denumire = "The vault",
                Imagine = "https://dnm.nflximg.net/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABfpChsjpBcO03TulPyqEr3WlxLZ5rWrE-fbUNQ1RvivUY41Y6tBvGCJG6toTcO_l_vZHXnawW6AsYYhR2SRYJApW9rgX.jpg?r=5ae",
                Descriere = "Netflix top 10"
            });
            
            lista.Add(new Sugestie
            {
                Denumire = "Shrek",
                Imagine = "https://dnm.nflximg.net/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABeFAYqweMXVHsOyxniIKISGdkJxrRgARhqFAo_oc_xHQpkpE73Wcx2SCYWUpcd8sLEOwRrfEQ12ugxYPwEgls6SZFYiE.jpg?r=e1b",
                Descriere = "Netflix top 10"
            });
            
            lista.Add(new Sugestie
            {
                Denumire = "Cleaner",
                Imagine = "https://dnm.nflximg.net/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABU7p5KdgVXhiMo6MSTXesSFI1GZvUxrS6Y62XhffMedvlEdTG9EXWBhQZocK0wng5hyqPrLopFzL968tsKo48_hgiubH.jpg?r=4d9",
                Descriere = "Netflix top 10"
            });

            return lista;
        }

        private List<Sugestie> SugestiiCarti()
        {
            List<Sugestie> lista = new List<Sugestie>();

            lista.Add(new Sugestie
            {
                Denumire = "Iernile sufletului",
                Imagine = "https://carturesti.ro/blog/wp-content/uploads/2022/04/bestseller-carti.jpeg",
                Descriere = "Iernile sufletului ne arată, dintr-o perspectivă plină de speranță și acceptare, cum să îmbrățișezi perioadele dificile și momentele grele și să le privești mai degrabă ca pe niște șanse de a te dezvolta."
            });

            lista.Add(new Sugestie
            {
                Denumire = "Amandoi mor la sfarsit",
                Imagine = "https://carturesti.ro/blog/wp-content/uploads/2022/04/carti-bestseller.jpeg",
                Descriere = "Amândoi mor la sfârșit este o poveste devastatoare, dar totuși optimistă, despre doi oameni a căror viață se schimbă pe parcursul unei zile de neuitat."
            });

            lista.Add(new Sugestie
            {
                Denumire = "Trenul spre Samarkand",
                Imagine = "https://carturesti.ro/blog/wp-content/uploads/2022/04/cele-mai-citite-carti.jpeg",
                Descriere = "Aflat în topul bestsellerurilor 2021 din Cărturești, Trenul spre Samarkand este un roman istoric profund și emoționant care vorbește despre o temă foarte grea, tema foametei în masă."
            });

            lista.Add(new Sugestie
            {
                Denumire ="Ierburi uitate",
                Imagine = "https://carturesti.ro/blog/wp-content/uploads/2022/04/bestseller-carturesti.jpeg",
                Descriere = "Mona Petre, un graphic designer pasionat de botanică, pune la un loc în Ierburi uitate o colecție de căutări botanice, asocieri de gusturi și experimente culinare inspirate de flora spontană și reconstituie rețete vechi de sute de ani. "
            });

            lista.Add(new Sugestie
            {
                Denumire = "Intre doua lumi",
                Imagine = "https://carturesti.ro/blog/wp-content/uploads/2022/04/top-bestseller-carti.jpeg",
                Descriere = "Unul dintre cele mai citite volume de memorii din 2021, Între două lumi vorbește despre durere și frică, dar și despre vindecare și puterea de a o lua de la capăt."
            });

            lista.Add(new Sugestie
            {
                Denumire = "Pamantul fagaduintei",
                Imagine = "https://carturesti.ro/blog/wp-content/uploads/2021/02/top-carti-bestseller.jpeg",
                Descriere = "Pământul făgăduinței, primul volum al memoriilor prezidențiale ale lui Barack Obama, vorbește despre drumul parcurs de acesta de la un tânăr aflat în căutarea propriei identități la liderul lumii libere. "
            });

            lista.Add(new Sugestie
            {
                Denumire = "Din cer au cazut trei mere",
                Imagine = "https://carturesti.ro/blog/wp-content/uploads/2022/04/carti-bestseller-2021.jpeg",
                Descriere = "Aflată în topul cărților bestseller din 2021, Din cer au căzut trei mere te poartă într-un univers arhaic de basm, în care mitul și realitatea se împletesc într-un mod care cu greu poate fi pus la îndoială chiar și de către cei mai sceptici. "
            });

            return lista;
        }


        private void pickerTipActivitate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(pickerTipActivitate.SelectedItem.Equals("Filme"))
            {
                ListaSugestii = SugestiiFilme();
                carousel.ItemsSource = ListaSugestii;
            }
            if (pickerTipActivitate.SelectedItem.Equals("Carti"))
            {
                ListaSugestii = SugestiiCarti();
                carousel.ItemsSource = ListaSugestii;
            }
        }
    }
}