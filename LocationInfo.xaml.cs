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
    public sealed partial class LocationInfo : Page
    {

        Dictionary<string, LocationsList> locationInformation = new Dictionary<string, LocationsList>
        {
            {"MATAKANA ISLAND", new LocationsList() { Name="Matakana Island", Image="taurangaMap2.PNG", Permit= "No", Type="Saltwater, Harbour", Months="December, January, February and March", Fish = new string[]{"flounder", "trevally", "stingray", "kingfish"} }},
            {"PAPAMOA", new LocationsList() { Name="Papamoa", Image="taurangaMap2.PNG", Permit= "No", Type="Saltwater, Sea", Months="December, February, March and April", Fish = new string[]{"trevally", "stingray"}}},
            {"MOTITI ISLAND", new LocationsList() { Name="Motiti Island", Image="taurangaMap2.PNG", Permit= "No", Type="Saltwater", Months="February and March", Fish = new string[]{"flounder", "crayfish", "pilchard"}}}
        };


        public LocationInfo()
        {
            this.InitializeComponent();
        }
        private void btnBack_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Locations));
        }

        private void imgLogo_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string arrowNumber = (string)e.Parameter;
            fish1.Visibility = Visibility.Collapsed;
            fish2.Visibility = Visibility.Collapsed;
            fish3.Visibility = Visibility.Collapsed;
            fish4.Visibility = Visibility.Collapsed;

            switch (arrowNumber)
            {
                case ("1"):
                    title.Text = "PAPAMOA";
                    break;
                case ("2"):
                    title.Text = "MATAKANA ISLAND";
                    break;
                case ("3"):
                    title.Text = "MOTITI ISLAND";
                    break;
                case ("0"):
                    title.Text = "Sorry, Map has errored";
                    break;
                default:
                    title.Text = "Sorry, Information has errored";
                    break;
            }


            if (locationInformation.ContainsKey(title.Text.ToUpper()))
            {
                LocationsList location = locationInformation[title.Text];
                String imageString = "ms-appx:///Assets/" + location.Image;
                MapImg.Source = new BitmapImage(new Uri(imageString, UriKind.RelativeOrAbsolute));

                permitText.Text = location.Permit;
                typeText.Text = location.Type;
                monthText.Text = location.Months;

                if (location.Fish.Length > 0)
                {
                    fish1.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + location.Fish[0] + ".jpg"));
                    fish1.Visibility = Visibility.Visible;

                }
                if (location.Fish.Length > 1)
                {
                    fish2.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + location.Fish[1] + ".jpg"));
                    fish2.Visibility = Visibility.Visible;
                }
                if (location.Fish.Length > 2)
                {
                    fish3.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + location.Fish[2] + ".jpg"));
                    fish3.Visibility = Visibility.Visible;
                }
                if (location.Fish.Length > 3)
                {
                    fish4.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + location.Fish[3] + ".jpg"));
                    fish4.Visibility = Visibility.Visible;
                }


            }
            else
            {
                MapImg.Source = new BitmapImage(new Uri("ms-appx:///Assets/emptyMap.PNG", UriKind.RelativeOrAbsolute));
            }

        }
    }
}
