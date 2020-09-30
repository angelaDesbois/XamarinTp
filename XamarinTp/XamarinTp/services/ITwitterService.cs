using System;
using System.Collections.Generic;
using System.Text;
using XamarinTp.models;

namespace XamarinTp.services
{
    public interface ITwitterService
    {
        bool authenticate(String id, String password);
        List<Tweet> getTweets();
    }
}
