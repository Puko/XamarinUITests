using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            app.WaitForElement(c => c.Marked("Click me!"));
            app.Tap(c => c.Marked("Click me!"));
            app.Tap(c => c.Marked("Click me!"));
            app.Tap(c => c.Marked("Click me!")); 
            app.Tap(c => c.Marked("Click me!"));
            app.Tap(c => c.Marked("Click me!"));

            var results = app.WaitForElement(x => x.Text("5"));

            Assert.IsTrue(results.Any());
        }
    }
}
