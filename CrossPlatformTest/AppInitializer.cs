using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CrossPlatformTest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            //if (platform == Platform.Android)
            //{
                return ConfigureApp
                    .Android
                    .InstalledApp("com.companyname.EAXamarinApp")
                    //.ApkFile(@"C:\Users\toev\Downloads\Xamarin.UITest-master\EAXamarinApp\EAXamarinApp.Android\bin\Debug\com.companyname.EAXamarinApp-Signed.apk")
                    .DeviceSerial("2663afc820057ece")
                    //.DeviceSerial("712KPSL1234014")
                    .EnableLocalScreenshots()
                    .PreferIdeSettings()
                    .StartApp();
            //}

            //return ConfigureApp
            //    .iOS
            //    .StartApp();
        }
    }
}

