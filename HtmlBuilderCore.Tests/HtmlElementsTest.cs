using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HtmlBuilderCore.Elements;

namespace HtmlBuilderCore.Tests
{
    [TestClass]
    public class HtmlElementsTest
    {


        [TestMethod]
        public void Check_If_Html_Header_Returns_Correct_Html()
        {
            //arrange
            HtmlHeader head = new HtmlHeader();
            head.SizeOfString = 1;
            head.ContentString = "header";

            //act
            string genHtml = head.GetHtmlString();
            string expectedHtml = "<h1>header</h1>";
            //assert
            Assert.AreEqual(expectedHtml, genHtml);
        }

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


        [TestMethod]

        public void Check_if_Para_tag_returns_correct_html()

        {
            HtmlPara para = new HtmlPara();
            para.Text = "abc";

            string genHtml = para.GetHtmlString();
            string expectedHtml = "<p>abc</p>";

            Assert.AreEqual(expectedHtml, genHtml);
        }


        [TestMethod]

        public void Check_if_Link_tag_returns_correct_html()
        {
            HtmlLink lnk = new HtmlLink();
            lnk.LinkSrc = "www.google.com";
            lnk.LinkText = "google";

            string genHtml = lnk.GetHtmlString();
            string expectedHtml = "<a href='www.google.com'>google</a>";

            Assert.AreEqual(expectedHtml, genHtml);
        }

        [TestMethod]
        public void Check_if_Html_Table_return_correct_HtmlException()
        {
            HtmlTable table = new HtmlTable();
            table.Rows = 2;
            table.Columns = 2;
            table.FillData("Abd", "hgjh", "Def", "gsfg");

            string genHtml = table.GetHtmlString();
            string expectedHtml = "<table border='1'><tr><td>Abd</td><td>hgjh</td></tr><tr><td>Def</td><td>gsfg</td></tr></table>";

            Assert.AreEqual(expectedHtml, genHtml);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputException), "Please Enter Valid Input")]
        public void Check_if_Html_Table1_return_correct_HtmlException()
        {
            HtmlTable table = new HtmlTable();
            table.Rows = 2;
            table.Columns = 2;
            table.FillData("Abd", "hgjh", "Def", "gsfg", "dfgsdg");

            string genHtml = table.GetHtmlString();

        }
    }
}
