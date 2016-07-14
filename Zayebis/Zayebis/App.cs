
using Xamarin.Forms;

namespace Zayebis
{
    public class App : Application
    {
        private static readonly Locator _locator = new Locator();

        public static Locator Locator { get { return _locator; } }

        public App()
        {
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
