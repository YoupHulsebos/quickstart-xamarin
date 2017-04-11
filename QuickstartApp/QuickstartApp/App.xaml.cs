using Xamarin.Forms;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace QuickstartApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new QuickstartApp.MainPage();
        }

        protected override void OnStart()
        {
            /* 
             * Start Mobile Center SDK
             * Remember to replace {IOS_APP_SECRET} and {ANDROID_APP_SECRET} with your actual app secrets
             */
            MobileCenter.Start("ios=7516020c-7375-47d9-8316-881deb5a761e;android=19d235f4-ef8b-418d-ac31-840ed63595e1", typeof(Analytics), typeof(Crashes));
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
