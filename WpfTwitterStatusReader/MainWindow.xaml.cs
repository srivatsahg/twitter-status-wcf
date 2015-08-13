using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfTwitterStatusReader.TwitterReaderService;

namespace WpfTwitterStatusReader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StatusContractClient twitterClient;

        public MainWindow()
        {
            InitializeComponent();
            twitterClient = new StatusContractClient();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRequest_OnClick(object sender, RoutedEventArgs e)
        {
            //Here the application shall request to the WCF service
            TextBoxStatus.Text = twitterClient.GetTweetData().TweetStatus;
        }
    }
}
