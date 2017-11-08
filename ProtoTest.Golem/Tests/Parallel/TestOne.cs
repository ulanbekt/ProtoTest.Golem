﻿using NUnit.Framework;

namespace Golem.Tests
{
    [Parallelizable]
    internal class ParallelTestOne : WebDriverTestBase
    {
  
        [Test]
        public void TestOne()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            //Assert.Fail("Failing");
        }

        [Test]
        public void TestTwo()
        {
            driver.Navigate().GoToUrl("http://www.gmail.com");
        }
        
    }
}