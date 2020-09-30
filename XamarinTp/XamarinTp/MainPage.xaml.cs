using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinTp.models;
using XamarinTp.services;
using XamarinTp.Views;

namespace XamarinTp
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ITwitterService twitterService = new TwitterService();
        public MainPage()
        {
            InitializeComponent();
            this.loadTweet(this.TweetList);
            
        }

        private void loadTweet(StackLayout tweetList)
        {
            foreach(var tweet in twitterService.getTweets())
            {
                TweetView tweetView = new TweetView();
                tweetView.LoadData(tweet);
                tweetList.Children.Add(tweetView);
            }
        }

        private void connexion_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("connection is clicked");
            String id = this.id.Text;
            String password = this.password.Text;
            //Boolean seSouvenir = this.seSouvenir.IsToggled;

            this.erreur.IsVisible = false;

            if(this.twitterService.authenticate(id, password))
            {
                this.form.IsVisible = false;
                
                this.TweetList.IsVisible = true;
            }
            else
            {
                this.erreur.Text = "identifiants not ok";
                this.erreur.IsVisible = true;
            }

            //var testLogin = true;
            //var testPassword = true;

            //if (id == null || string.IsNullOrEmpty(id) || id.Length < 3)
            //{
            //    this.erreur.Text = "Entrer un id d au moins 3 caractères";
            //    this.erreur.IsVisible = true;
            //    testLogin = false;
               
            //}

            //if (password == null || string.IsNullOrEmpty(password) || password.Length < 6)
            //{
            //    this.erreur.Text = "Entrer un password d au moins 6 caractères";
            //    this.erreur.IsVisible = true;
            //    testPassword = false;
               
            //}

            //if(testPassword && testLogin)
            //{
            //    this.form.IsVisible = false;
            //    this.tweet.IsVisible = true;
               
            //}

           // if (this.seSouvenir.IsToggled)
            //{
             //   DisplayAlert("Info", "Vous serez connecté automatiquement au prochain lancement", "Compris");
           // }

            
        }
    }
}
