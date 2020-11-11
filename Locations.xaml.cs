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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace HLS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Locations : Page
    {       

        Dictionary<string, LocationsList> locationDictionary = new Dictionary<string, LocationsList>
        {
            {"Auckland", new LocationsList() { Name="Auckland", Image="aucklandMap.PNG"}},
            {"Napier", new LocationsList() { Name="Napier", Image="napierMap.PNG"}},
            {"New Plymouth", new LocationsList() { Name="New Plymouth", Image="npMap.PNG"}},
            {"Rotorua", new LocationsList() { Name="Rotorua", Image="rotoruaMap.PNG"}},
            {"Tauranga", new LocationsList() { Name="Tauranga", Image="taurangaMap2.PNG"}},
            {"Whanganui", new LocationsList() { Name="Whanganui", Image="whanganuiMap.PNG"}},
            {"Whangarei", new LocationsList() { Name="Whangarei", Image="whangareiMap.PNG"}}
        };

        public Locations()
        {
            this.InitializeComponent();
        }
        private void btnBack_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void imgLogo_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void arrowImg_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string arrowNumber = "";

            var ImageName = ((Image)sender).Name.ToString();

            switch (ImageName)
            {
                case ("arrow1Img"):
                    arrowNumber = "1";
                    break;
                case ("arrow2Img"):
                    arrowNumber = "2";
                    break;
                case ("arrow3Img"):
                    arrowNumber = "3";
                    break;
                default:
                    arrowNumber = "0";
                    break;
            }

            this.Frame.Navigate(typeof(LocationInfo), arrowNumber);

        }

        private void locationsDDL_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = locationsDDL.SelectedItem.ToString();

            if (selected != "Tauranga"){
                arrow1Img.Visibility = Visibility.Collapsed;
                arrow2Img.Visibility = Visibility.Collapsed;
                arrow3Img.Visibility = Visibility.Collapsed;
            }
            else
            {
                arrow1Img.Visibility = Visibility.Visible;
                arrow2Img.Visibility = Visibility.Visible;
                arrow3Img.Visibility = Visibility.Visible;
            }

            if (locationDictionary.ContainsKey(locationsDDL.SelectedItem.ToString()) == false)
            {
                MapImg.Source = new BitmapImage(new Uri("ms-appx:///Assets/emptyMap.PNG", UriKind.RelativeOrAbsolute));
                
            }
            else
            {
                LocationsList location = locationDictionary[locationsDDL.SelectedItem.ToString()];
                String imageString = "ms-appx:///Assets/" + location.Image;
                MapImg.Source = new BitmapImage(new Uri(imageString, UriKind.RelativeOrAbsolute));
            }
        }
    }
}
