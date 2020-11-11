using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace HLS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FishIndentifier : Page
    {
        public FishIndentifier()
        {
            this.InitializeComponent();

        }
        private void imgLogo_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void btnBack_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void fishIdentifierImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Random random = new Random();
            int RandomNumber = random.Next(1, 10);

            this.Frame.Navigate(typeof(FishInfo), RandomNumber.ToString());
        }

        private void infoButton_Click(object sender, RoutedEventArgs e)
        {
            if (infoText.Visibility == Visibility.Visible)
            {
                infoText.Visibility = Visibility.Collapsed;
            }
            else
            {
                infoText.Visibility = Visibility.Visible;
            }


        }

    }
}
