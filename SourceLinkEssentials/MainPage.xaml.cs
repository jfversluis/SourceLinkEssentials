using System.ComponentModel;
using Xamarin.Forms;

namespace SourceLinkEssentials
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var fooLabel = new Xamarin.Forms.Label();

            Xamarin.Essentials.Geocoding.GetLocationsAsync("1 Microsoft Way, Redmond");
        }
    }
}