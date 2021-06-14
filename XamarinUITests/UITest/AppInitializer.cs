using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
{
    public class AppInitializer
    {

        //com.companyname.xamarinuitests
        //1170191635
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.InstalledApp("com.companyname.xamarinuitests").StartApp(Xamarin.UITest.Configuration.AppDataMode.DoNotClear);
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}