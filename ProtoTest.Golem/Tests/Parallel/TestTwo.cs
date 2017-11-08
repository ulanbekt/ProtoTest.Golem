﻿using NUnit.Framework;

namespace Golem.Tests
{
    [Parallelizable]
    internal class ParallelTestTwo : WebDriverTestBase
    {

        [Test]
        public void TestOne()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        [Test]
        public void TestTwo()
        {
            driver.Navigate().GoToUrl("http://www.gmail.com");
        }

    }
}