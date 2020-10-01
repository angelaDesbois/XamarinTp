using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTp.models;
using XamarinTp.services;

namespace XamarinTp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetView : ContentView
    {
       // private ObservableCollection<Tweet> tweets = new ObservableCollection<Tweet>();
       // private ITwitterService twitterService = new TwitterService();
        public TweetView()
        {
            InitializeComponent();

         //   foreach(var item in twitterService.getTweets())
         //   {
          //      tweets.Add(item);
         //   }
             
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
