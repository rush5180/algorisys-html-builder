using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HtmlBuilderCore.Elements;

namespace HtmlBuilderCore.Tests
{
    [TestClass]
    public class HtmlElementsTest
    {

        [TestMethod]
        public void Check_If_Html_Image_Returns_Correct_Html()
        {
            //arrange
            HtmlImage img = new HtmlImage();
            img.ImageSrc = "https://en.wikipedia.org/wiki/File:C_Sharp_wordmark.svg";
            img.Alt = "Logo";

            //act
            string genHtml = img.GetHtmlString();
            string expectedHtml = "<img src='https://en.wikipedia.org/wiki/File:C_Sharp_wordmark.svg' alt='Logo' />";
            //assert
            Assert.AreEqual(expectedHtml, genHtml);
        }

        [TestMethod]
        public void Check_if_HR_tag_returns_correct_html()
        {
            HtmlHr hr = new HtmlHr();
            hr.Color = "blue";

            string genHtml = hr.GetHtmlString();
            string expectedHtml = "<hr style='border-color:blue'>";

            Assert.IsInstanceOfType(hr, typeof(IHtmlElement));
            Assert.AreEqual(expectedHtml, genHtml);
        }
    }
}
