
using Xamarin.Forms;

namespace Zayebis
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.Main;
        }
    }
}
