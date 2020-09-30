using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTp
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void connexion_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("connection is clicked");
            String id = this.id.Text;
            String password = this.password.Text;
            Boolean seSouvenir = this.seSouvenir.IsToggled;

            this.erreur.IsVisible = false;

            if(id == null || string.IsNullOrEmpty(id) || id.Length < 3)
            {
                this.erreur.Text = "Entrer un id d au moins 3 caractères";
                this.erreur.IsVisible = true;
                return;
            }

            if (password == null || string.IsNullOrEmpty(password) || password.Length < 6)
            {
                this.erreur.Text = "Entrer un password d au moins 6 caractères";
                this.erreur.IsVisible = true;
                return;
            }

            if (this.seSouvenir.IsToggled)
            {
                DisplayAlert("Info", "Vous serez connecté automatiquement au prochain lancement", "Compris");
            }

            this.form.IsVisible = false;
            this.tweet.IsVisible = true;
        }
    }
}
