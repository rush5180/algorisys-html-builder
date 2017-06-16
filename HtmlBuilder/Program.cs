using HtmlBuilderCore;
using HtmlBuilderCore.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing();

           

        }

        private static void Testing()
        {
            HtmlImage img = new HtmlImage();
            img.ImageSrc = "https://en.wikipedia.org/wiki/File:C_Sharp_wordmark.svg";
            img.Alt = "Logo";

            HtmlPara pr = new HtmlPara();
            pr.Text = "My paragraph";

            HtmlLink lnk = new HtmlLink();
            lnk.LinkSrc = "http://yahoo/.com";
            lnk.LinkText = "Yahooo!!";

            HtmlPage page = new HtmlPage();
            page.Title = "My fabulous page";
            page.BodyColor = "yellow";
            page.Elements.Add(img);
            page.Elements.Add(pr);

            page.Elements.Add(lnk);


            var html = page.GetPageHtml();
        }

        static void P(string s)
        {
            Console.WriteLine(s);
        }

        static string ReadString(string msg)
        {
            P(msg);
            return Console.ReadLine();
        }
        static int ReadInt(string msg)
        {
            return Convert.ToInt32(ReadString(msg));
        }
        static ConsoleKey ReadKey()
        {
            return Console.ReadKey().Key;
        }


        
    }
}
