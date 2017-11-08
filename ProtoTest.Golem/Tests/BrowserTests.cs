﻿using NUnit.Framework;
using Golem.Core;
using Golem.WebDriver;

namespace Golem.Tests
{
    internal class BrowserTests : TestBase
    {
//        [OneTimeSetUp]
//        public void Init()
//        {
//            Config.settings.runTimeSettings.LaunchBrowser = false;
//        }
//
//        [OneTimeTearDown]
//        public void Teardown()
//        {
//            Config.settings.runTimeSettings.LaunchBrowser = true;
//        }
//
//        [Test]
//        public void TestIE()
//        {
//            driver = new InternetExplorerDriver();
//            OpenPage<GoogleHomePage>("http://www.google.com/");
//            driver.Quit();
//        }
//
//        [Test]
//        public void TestFF()
//        {
//            driver = new FirefoxDriver();
//            OpenPage<GoogleHomePage>("http://www.google.com/");
//            driver.Quit();
//        }
//
//        [Test]
//        public void TestChrome()
//        {
//            driver = new ChromeDriver();
//            OpenPage<GoogleHomePage>("http://www.google.com/");
//            driver.Quit();
//        }
//
//        [Test]
//        public void TestPhantomJS()
//        {
//            driver = new PhantomJSDriver();
//            OpenPage<GoogleHomePage>("http://www.google.com/");
//            driver.Quit();
//        }
//
//        [Test]
//        public void TestSafari()
//        {
//            driver = new SafariDriver();
//            OpenPage<GoogleHomePage>("http://www.google.com/");
//            driver.Quit();
//        }

        [Test]
        public void TestRemote()
        {
           var driver = new WebDriverBrowser().LaunchRemoteBrowser(WebDriverBrowser.Browser.Chrome,
                "127.0.0.1");
            driver.Navigate().GoToUrl("http://www.google.com/");
            driver.Quit();
        }
    }
}