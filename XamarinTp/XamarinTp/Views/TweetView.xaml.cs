using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTp.models;

namespace XamarinTp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetView : ContentView
    {
        public TweetView()
        {
            InitializeComponent();
        }

        public void LoadData(Tweet tweet)
        {
            this.pseudoUser.Text = tweet.pseudoUser;
            this.id.Text = tweet.id;
            this.dateCreation.Text = tweet.dateCreation;
            this.texte.Text = tweet.text;

        }
    }
   
}
