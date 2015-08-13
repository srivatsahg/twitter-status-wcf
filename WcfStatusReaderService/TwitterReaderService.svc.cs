using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web.Script.Serialization;
using System.Text;

namespace WcfStatusReaderService
{
    public class TwitterReaderService : IStatusContract
    {
        public TwitterReaderService()
        {

        }

        #region Interface implementation

        public string GetTweets(int tweets)
        {
            return "Top 10 tweets";
        }

        public TweetData GetTweetData()
        {
            return new TweetData
            {
                DateTimeStamp = DateTime.Now,
                TweetStatus = "Hello from Twitter.",
                UserName = "srivatsahg"
            };
        }

        public string GetTop10Tweets()
        {
            return "Test success";
        }

        #endregion Interface implementation
    }
}
