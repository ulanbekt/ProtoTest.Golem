﻿using System.Linq;
using NUnit.Framework;
using Golem.Tests.PageObjects.Google;

namespace Golem.Tests
{
    class TestComponent : WebDriverTestBase
    {
        [Test]
        public void TestBaseComponentActsLikeElement()
        {
            var item =
                OpenPage<GoogleResultsPage>("https://www.google.com/#q=selenium")
                    .SearchItem.First(x => x.Text.Contains("wikipedia"));
            item.Highlight(-1, "grey");
            item.Link.Verify().Visible();
            item.Description.Verify().Visible();
            item.Url.Verify().Visible();
        }

        [Test]
        public void TestComponents()
        { 
            var item =
                OpenPage<GoogleResultsPage>("https://www.google.com/#q=selenium")
                    .SearchItem.First(x => x.Text.Contains("wikipedia"));
            item.Description.Verify().Text("Selenium is a portable software testing framework for web applications");
        }

        [Test]
        public void TestHeader()
        {
            var item =
                OpenPage<GoogleResultsPage>("https://www.google.com/#q=selenium").Header.Search.Verify().Visible();
        }

    }
}
