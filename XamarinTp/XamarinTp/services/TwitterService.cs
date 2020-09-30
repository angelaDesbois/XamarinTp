using System;
using System.Collections.Generic;
using System.Text;
using XamarinTp.models;

namespace XamarinTp.services
{
    public class TwitterService : ITwitterService
    {
        public bool authenticate(string nomUser, string password)
        {
            if(nomUser.Equals("andrea") && password.Equals("123456"))
            {
                return true;
            }
            return false;
        }

        public List<Tweet> getTweets()
        {
            var tweets = new List<Tweet>();

            tweets.Add(new Tweet()
            {
                dateCreation = "01/09/2020",
                id = "001",
                idUser = "0011",
                nomUser = "blabla",
                pseudoUser = "bloblo",
                text = "blablabxbcbcbcbhg"
            });

            tweets.Add(new Tweet()
            {
                dateCreation = "02/09/2020",
                id = "002",
                idUser = "0011",
                nomUser = "blabla",
                pseudoUser = "bloblo",
                text = "blablabxbcbcbcbhgplouf"
            });
            return tweets;
        }
    }
}
