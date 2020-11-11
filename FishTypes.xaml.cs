using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public sealed partial class FishTypes : Page
    {
        Dictionary<string, LocationsList> locationDictionary = new Dictionary<string, LocationsList>
        {
            {"Auckland", new LocationsList() { Name="Auckland", Image="aucklandMap.PNG", Fish = new string[]{"snapper", "crayfish", "trevally", "squad"}}},
            {"Napier", new LocationsList() { Name="Napier", Image="napierMap.PNG", Fish = new string[]{"flounder", "kingfish", "stingray"}}},
            {"New Plymouth", new LocationsList() { Name="New Plymouth", Image="npMap.PNG", Fish = new string[]{"johnDory", "crayfish"}}},
            {"Rotorua", new LocationsList() { Name="Rotorua", Image="rotoruaMap.PNG", Fish = new string[]{"stingray", "trevally", "kingfish", "squid"}}},
            {"Tauranga", new LocationsList() { Name="Tauranga", Image="taurangaMap2.PNG", Fish = new string[]{"kahawai", "crayfish", "stingray", "kingfish", "pilchard", "flounder", "trevally"}}},
            {"Whanganui", new LocationsList() { Name="Whanganui", Image="whanganuiMap.PNG", Fish = new string[]{"pilchard", "crayfish", "kingfish", "snapper", "flounder"}}},
            {"Whangarei", new LocationsList() { Name="Whangarei", Image="whangareiMap.PNG", Fish = new string[]{"snapper", "squid", "johnDory"}}}
        };

        Dictionary<string, FishList> fishDictionary = new Dictionary<string, FishList>
        {
            {"snapper", new FishList() { Name="Snapper", Image="snapper.jpg"}},
            {"crayfish", new FishList() { Name="Crayfish", Image="crayfish.jpg"}},
            {"flounder", new FishList() { Name="Flounder", Image="flounder.jpg"}},
            {"johnDory", new FishList() { Name="John Dory", Image="johnDory.jpg"}},
            {"kahawai", new FishList() { Name="Kahawai", Image="kahawai.jpg"}},
            {"kingfish", new FishList() { Name="Kingfish", Image="kingfish.jpg"}},
            {"squid", new FishList() { Name="Squid", Image="squid.jpg"}},
            {"stingray", new FishList() { Name="Stingray", Image="stingray.jpg"}},
            {"trevally", new FishList() { Name="Trevally", Image="trevally.jpg"}},
            {"pilchard", new FishList() { Name="Pilchard", Image="pilchard.jpg"}}
        };

        public FishTypes()
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
        private void fishType_Tapped(object sender, TappedRoutedEventArgs e)
        {

            string fishNumber = "";

            var ImageName = ((Image)sender).Name.ToString();

            switch (ImageName)
            {
                case ("Snapper"):
                    fishNumber = "1";
                    break;
                case ("Crayfish"):
                    fishNumber = "2";
                    break;
                case ("Flounder"):
                    fishNumber = "3";
                    break;
                case ("Kingfish"):
                    fishNumber = "4";
                    break;
                case ("Kahawai"):
                    fishNumber = "5";
                    break;
                case ("Squid"):
                    fishNumber = "6";
                    break;
                case ("Trevally"):
                    fishNumber = "7";
                    break;
                case ("John Dory"):
                    fishNumber = "8";
                    break;
                case ("Pilchard"):
                    fishNumber = "9";
                    break;
                case ("Stingray"):
                    fishNumber = "10";
                    break;
                default:
                    fishNumber = "0";
                    break;
            }

            this.Frame.Navigate(typeof(FishInfo), fishNumber);
        }

        private void locationsDDL_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = locationsDDL.SelectedItem.ToString();

            if (fishTypesGrid != null)
            {
                fishTypesGrid.Children.Clear();
                stingray.Visibility = Visibility.Collapsed;
                snapper.Visibility = Visibility.Collapsed;
                crayfish.Visibility = Visibility.Collapsed;
                flounder.Visibility = Visibility.Collapsed;
                kahawai.Visibility = Visibility.Collapsed;
                kingfish.Visibility = Visibility.Collapsed;
                trevally.Visibility = Visibility.Collapsed;
                johnDory.Visibility = Visibility.Collapsed;
                pilchard.Visibility = Visibility.Collapsed;
                squid.Visibility = Visibility.Collapsed;

                if (locationDictionary.ContainsKey(locationsDDL.SelectedItem.ToString()) == false)
                {
                    snapper.Source = new BitmapImage(new Uri("ms-appx:///Assets/emptyMap.PNG", UriKind.RelativeOrAbsolute));

                }
                else
                {
                    LocationsList location = locationDictionary[locationsDDL.SelectedItem.ToString()];

                    int nextFish = 0;
                    int fishLength = location.Fish.Length;
                    decimal i = 0;
                    decimal j = 0;
                    decimal k = 0;

                    for (int a = 0; a < fishLength; a++)
                    {

                        if (fishDictionary.ContainsKey(location.Fish[nextFish]) == false)
                        {
                            snapper.Visibility = Visibility.Visible;
                            snapper.Source = new BitmapImage(new Uri("ms-appx:///Assets/emptyMap.PNG", UriKind.RelativeOrAbsolute));
                        }
                        else
                        {

                            FishList fish = fishDictionary[location.Fish[nextFish]];

                            Image fishVisible = new Image();
                            fishVisible.HorizontalAlignment = HorizontalAlignment.Center;
                            fishVisible.VerticalAlignment = VerticalAlignment.Center;
                            fishVisible.Visibility = Visibility.Visible;
                            fishVisible.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + fish.Image));
                            fishVisible.Margin = new Thickness(0, 0, 0, 10);
                            fishVisible.Height = 137;
                            fishVisible.Width = 137;
                            fishVisible.Tapped += fishType_Tapped;
                            fishVisible.Name = fish.Name;

                            int row = Decimal.ToInt32(i);
                            int column = Decimal.ToInt32(j);

                            Grid.SetRow(fishVisible, row);
                            Grid.SetColumn(fishVisible, column);
                            fishTypesGrid.Children.Add(fishVisible);

                        }
                        k++;

                        if (j == 0)
                        {
                            j = 1;
                        }
                        else if (j == 1)
                        {
                            j = 0;
                        }

                        i = Math.Truncate(k / 2);
                        nextFish++;

                    }


                }
            }
        }

    }
}
