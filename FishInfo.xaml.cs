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
    public sealed partial class FishInfo : Page
    {

        Dictionary<string, FishList> fishDictionary = new Dictionary<string, FishList>
        {
            {"SNAPPER", new FishList() { Name="Snapper", Image="snapper.jpg", Family="Sparidae", Size="30cm", Bait="Pilchard, Squid",
                DescOne="Golden-pink to tones of red above, flecked with blue spots, with the colour paling to white on the belly. Snapper found in muddy harbours tend to be pale pink.",
                DescTwo="Snapper found near reefs and weed tend to be a red bronze. Snapper have a large head, strong teeth, and moderately firm scales."}},
            {"CRAYFISH", new FishList() { Name="Crayfish", Image="crayfish.jpg", Family="Parastacidae", Size="216mm", Bait="Lettuce",
                DescOne="Popularly known as crays, crayfish resemble lobsters but lack the lobster's large crushing pincers on their first pair of walking legs.",
                DescTwo="They feed on aquatic plants, insects, worms and molluscs, and may also scavenge. They inhabit rocky reefs at depths of 5 to 275 metres."}},
            {"FLOUNDER", new FishList() { Name="Flounder", Image="flounder.jpg", Family="Pleuronectidae", Size="23cm", Bait="Shrimps, Worms",
                DescOne="On the right side, the fish is a greenish brown dark colour or grey with faint mottling and on the left side (the side it lies on without eyes) it is white.",
                DescTwo="The flounder come into very shallow water - sometimes only inches deep - after sunset. Night fishing in the summer flounder season with an underwater light and spear or gig is very simple and productive."}},
            {"JOHN DORY", new FishList() { Name="John Dory", Image="johnDory.jpg", Family="Zeidae", Size=" - ", Bait="Bonito, Squid",
                DescOne="John Dory are distinguished by the dark blue spot ringed with white in the centre of each side of their body. They are caught year-round in coastal waters.",
                DescTwo="John dory are midwater to seafloor dwelling. While found throughout New Zealand they are most common north of the Cook Strait."}},
            {"KAHAWAI", new FishList() { Name="Kahawai", Image="kahawai.jpg", Family="Arripidae", Size=" - ", Bait="Pilchard, Squid",
                DescOne="They are a firm, silvery fish ranging from grey-blue to blue-green on top and silver below. They have rows of black spots along their flanks.",
                DescTwo="These fish are fast swimming, active carnivores which feed primarily on smaller fishes such as anchovies and yellow-eyed mullet, although they will feed on euphausid crustaceans when these are abundant."}},
            {"KINGFISH", new FishList() { Name="Kingfish", Image="kingfish.jpg", Family="Carangidae", Size="75cm", Bait="Live Bait - Small",
                DescOne="They are generally dark green in colour, with a white stomach,  and a yellow stripe which runs along the pectoral line to their caudal fin.",
                DescTwo="The depth at which kingfish are found can vary, as they do often move into the shallows to hunt. Generally, they prefer rocky reef structures and pinnacles; with current moving past them."}},
            {"SQUID", new FishList() { Name="Squid", Image="squid.jpg", Family="Ommastrephidae", Size=" - ", Bait="Soft Bait",
                DescOne="New Zealand has more than 85 species of squid, most of them in the open sea. Adult giant squid breed in deep waters around New Zealand. ",
                DescTwo="Females reach 13 metres in length. They have eyes the size of dinner plates to see flashes of light from passing fish, which they eat"}},
            {"STINGRAY", new FishList() { Name="Stingray", Image="stingray.jpg", Family="Myliobatidae", Size="27cm", Bait="Squid",
                DescOne="Stingrays have broad fins that run the full length of their bodies, giving them a flat, roundish shape.",
                DescTwo="To swim, some stingrays move their whole bodies in a wavy motion that propels them through the water. "}},
            {"TREVALLY", new FishList() { Name="Trevally", Image="trevally.jpg", Family="Carangidae", Size="27cm", Bait="Bonito, Pilchard",
                DescOne="Adult schools are often seen near headlands, pinnacles and islands where currents tend to concentrate a lot of plankton. Trevally are mostly plankton feeders.",
                DescTwo="In summer trevally form close-packed schools and can be found in depths of anywhere up to 100 metres. "}},
            {"PILCHARD", new FishList() { Name="Pilchard", Image="pilchard.jpg", Family="Clupeidae", Size=" - ", Bait="Squid",
                DescOne="The pilchard, sardine, or Picton herring, is 5–8 in. in length and silver in colour, slightly darker above.",
                DescTwo="Occurring in vast schools, pilchards are taken as food by many other fish, including both surface and bottom-dwelling species, as well as by seabirds."}}
        };

        public FishInfo()
        {
            this.InitializeComponent();
        }

        private void btnBack_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FishTypes));
        }

        private void imgLogo_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string fishNumber = (string)e.Parameter;

            switch (fishNumber)
            {
                case ("1"):
                    title.Text = "SNAPPER";
                    break;
                case ("2"):
                    title.Text = "CRAYFISH";
                    break;
                case ("3"):
                    title.Text = "FLOUNDER";
                    break;
                case ("4"):
                    title.Text = "KINGFISH";
                    break;
                case ("5"):
                    title.Text = "KAHAWAI";
                    break;
                case ("6"):
                    title.Text = "SQUID";
                    break;
                case ("7"):
                    title.Text = "TREVALLY";
                    break;
                case ("8"):
                    title.Text = "JOHN DORY";
                    break;
                case ("9"):
                    title.Text = "PILCHARD";
                    break;
                case ("10"):
                    title.Text = "STINGRAY";
                    break;
                case ("0"):
                    title.Text = "Sorry, Fish Selection has errored";
                    break;
                default:
                    title.Text = "Sorry, Information has errored";
                    break;
            }


            if (fishDictionary.ContainsKey(title.Text))
            {
                FishList fishSelected = fishDictionary[title.Text]; ;
                String imageString = "ms-appx:///Assets/" + fishSelected.Image;
                fishImg.Source = new BitmapImage(new Uri(imageString, UriKind.RelativeOrAbsolute));

                familyText.Text = fishSelected.Family;
                sizeText.Text = fishSelected.Size;
                baitText.Text = fishSelected.Bait;
                descriptionText.Text = fishSelected.DescOne;
                descriptionText2.Text = fishSelected.DescTwo; 

            }
            else
            {
                fishImg.Source = new BitmapImage(new Uri("ms-appx:///Assets/emptyMap.PNG", UriKind.RelativeOrAbsolute));
            }

        }
    }
}
