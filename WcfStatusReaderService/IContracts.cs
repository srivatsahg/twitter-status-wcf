using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfStatusReaderService
{
    [ServiceContract]
    public interface IStatusContract
    {
        [OperationContract]
        string GetTweets(int tweets);

        [OperationContract]
        TweetData GetTweetData();

        [OperationContract]
        string GetTop10Tweets();
    }

    [DataContract]
    public class TweetData
    {
        [DataMember]
        public DateTime DateTimeStamp { get; set; }

        [DataMember]
        public string TweetStatus { get; set; }

        [DataMember]
        public string UserName { get; set; }
    }
}
