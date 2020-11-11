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
    public sealed partial class Warnings : Page
    {
        public Warnings()
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

        private void yellowWarning2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            taurangaExpanded.Visibility = Visibility.Visible;
            orangeWarning.Opacity = 0.3;
            redWarning.Opacity = 0.3;
            yellowWarning.Opacity = 0.3;

            taurangaExpandedHeading.Visibility = Visibility.Visible;
            taurangaExpandedInfo.Visibility = Visibility.Visible;
            taurangaExpandedInfo.Text = "Strong Wind and Rain Watch" + Environment.NewLine + Environment.NewLine +
            "Heavy rain and wind overnight." + Environment.NewLine +
            "Be prepared for heavy rain and slight flooding is possible " + Environment.NewLine +
            "in low lying areas and houses by the water." + Environment.NewLine + Environment.NewLine +
            "Power outages are possible.";

            taupoWarning.IsTapEnabled = taupoWarningInfo.IsTapEnabled = orangeWarning.IsTapEnabled =
            aucklandWarning.IsTapEnabled = aucklandWarningInfo.IsTapEnabled = redWarning.IsTapEnabled =
            tauranga2WarningInfo.IsTapEnabled = tauranga2WarningInfo.IsTapEnabled = yellowWarning.IsTapEnabled = false;
        }

        private void taurangaExpanded_Tapped(object sender, TappedRoutedEventArgs e)
        {
            taurangaExpandedHeading.Visibility = Visibility.Collapsed;
            taurangaExpandedInfo.Visibility = Visibility.Collapsed;
            taurangaExpanded.Visibility = Visibility.Collapsed;
            orangeWarning.Opacity = 1;
            redWarning.Opacity = 1;
            yellowWarning.Opacity = 1;

            taupoWarning.IsTapEnabled = taupoWarningInfo.IsTapEnabled = orangeWarning.IsTapEnabled =
            aucklandWarning.IsTapEnabled = aucklandWarningInfo.IsTapEnabled = redWarning.IsTapEnabled = 
            tauranga2WarningInfo.IsTapEnabled = tauranga2WarningInfo.IsTapEnabled = yellowWarning.IsTapEnabled = true;
        }
        private void redWarning_Tapped(object sender, TappedRoutedEventArgs e)
        {
            aucklandExpanded.Visibility = Visibility.Visible;
            orangeWarning.Opacity = 0.3;
            yellowWarning2.Opacity = 0.3;
            yellowWarning.Opacity = 0.3;

            aucklandExpandedHeading.Visibility = Visibility.Visible;
            aucklandExpandedInfo.Visibility = Visibility.Visible;
            aucklandExpandedInfo.Text = "Severe Thunderstorm Watch" + Environment.NewLine + Environment.NewLine +
            "Heavy rain and wind overnight." + Environment.NewLine +
            "Be prepared for gail force winds and hail at times and please " + Environment.NewLine +
            "tie down any objects that can become projectiles." + Environment.NewLine + Environment.NewLine +
            "Please keep animals inside!";

            taupoWarning.IsTapEnabled = taupoWarningInfo.IsTapEnabled = orangeWarning.IsTapEnabled =
            taurangaWarning.IsTapEnabled = taurangaWarningInfo.IsTapEnabled = yellowWarning2.IsTapEnabled =
            tauranga2WarningInfo.IsTapEnabled = tauranga2WarningInfo.IsTapEnabled = yellowWarning.IsTapEnabled = false;
        }

        private void aucklandExpanded_Tapped(object sender, TappedRoutedEventArgs e)
        {
            aucklandExpandedHeading.Visibility = Visibility.Collapsed;
            aucklandExpandedInfo.Visibility = Visibility.Collapsed;
            aucklandExpanded.Visibility = Visibility.Collapsed;
            orangeWarning.Opacity = 1;
            yellowWarning2.Opacity = 1;
            yellowWarning.Opacity = 1;

            taupoWarning.IsTapEnabled = taupoWarningInfo.IsTapEnabled = orangeWarning.IsTapEnabled =
            taurangaWarning.IsTapEnabled = taurangaWarningInfo.IsTapEnabled = yellowWarning2.IsTapEnabled =
            tauranga2WarningInfo.IsTapEnabled = tauranga2WarningInfo.IsTapEnabled = yellowWarning.IsTapEnabled = true;
        }

        private void orangeWarning_Tapped(object sender, TappedRoutedEventArgs e)
        {
            taupoExpanded.Visibility = Visibility.Visible;
            yellowWarning2.Opacity = 0.3;
            redWarning.Opacity = 0.3;
            yellowWarning.Opacity = 0.3;

            taupoExpandedHeading.Visibility = Visibility.Visible;
            taupoExpandedInfo.Visibility = Visibility.Visible;
            taupoExpandedInfo.Text = "Toxic Algae Warning" + Environment.NewLine + Environment.NewLine +
            "Exposure to the toxic algae bloom" + Environment.NewLine +
            "on Lake Taupo could result in breathing difficulties." + Environment.NewLine +
            "Can cause eye irritation, breathing difficulties" + Environment.NewLine +
            "if inhaled, and stomach upsets." + Environment.NewLine + Environment.NewLine +
            "Very dangerous to animals!";

            aucklandWarning.IsTapEnabled = aucklandWarningInfo.IsTapEnabled = redWarning.IsTapEnabled =
            taurangaWarning.IsTapEnabled = taurangaWarningInfo.IsTapEnabled = yellowWarning2.IsTapEnabled =
            tauranga2WarningInfo.IsTapEnabled = tauranga2WarningInfo.IsTapEnabled = yellowWarning.IsTapEnabled = false;

        }

        private void taupoExpanded_Tapped(object sender, TappedRoutedEventArgs e)
        {
            taupoExpandedHeading.Visibility = Visibility.Collapsed;
            taupoExpandedInfo.Visibility = Visibility.Collapsed;
            taupoExpanded.Visibility = Visibility.Collapsed;
            yellowWarning2.Opacity = 1;
            redWarning.Opacity = 1;
            yellowWarning.Opacity = 1;

            aucklandWarning.IsTapEnabled = aucklandWarningInfo.IsTapEnabled = redWarning.IsTapEnabled =
            taurangaWarning.IsTapEnabled = taurangaWarningInfo.IsTapEnabled = yellowWarning2.IsTapEnabled =
            tauranga2WarningInfo.IsTapEnabled = tauranga2WarningInfo.IsTapEnabled = yellowWarning.IsTapEnabled = true;

        }

        private void yellowWarning_Tapped(object sender, TappedRoutedEventArgs e)
        {
            tauranga2Expanded.Visibility = Visibility.Visible;
            orangeWarning.Opacity = 0.3;
            redWarning.Opacity = 0.3;
            yellowWarning2.Opacity = 0.3;

            tauranga2ExpandedHeading.Visibility = Visibility.Visible;
            tauranga2ExpandedInfo.Visibility = Visibility.Visible;
            tauranga2ExpandedInfo.Text = "Strong Wind Watch" + Environment.NewLine + Environment.NewLine +
            "Heavy wind today and overnight." + Environment.NewLine +
            "Be prepared for strong winds that can cause slight damage" + Environment.NewLine +
            "to property. Be careful driving and watch for fallen branches." + Environment.NewLine + Environment.NewLine +
            "Power outages are possible.";

            aucklandWarning.IsTapEnabled = aucklandWarningInfo.IsTapEnabled = redWarning.IsTapEnabled =
            taupoWarning.IsTapEnabled = taupoWarningInfo.IsTapEnabled = orangeWarning.IsTapEnabled =
            taurangaWarningInfo.IsTapEnabled = taurangaWarningInfo.IsTapEnabled = yellowWarning2.IsTapEnabled = false;
        }
        private void tauranga2Expanded_Tapped(object sender, TappedRoutedEventArgs e)
        {
            tauranga2ExpandedHeading.Visibility = Visibility.Collapsed;
            tauranga2ExpandedInfo.Visibility = Visibility.Collapsed;
            tauranga2Expanded.Visibility = Visibility.Collapsed;
            orangeWarning.Opacity = 1;
            redWarning.Opacity = 1;
            yellowWarning2.Opacity = 1;

            aucklandWarning.IsTapEnabled = aucklandWarningInfo.IsTapEnabled = redWarning.IsTapEnabled = 
            taupoWarning.IsTapEnabled = taupoWarningInfo.IsTapEnabled = orangeWarning.IsTapEnabled = 
            taurangaWarningInfo.IsTapEnabled = taurangaWarningInfo.IsTapEnabled = yellowWarning2.IsTapEnabled = true;
            
        }


    }
}
