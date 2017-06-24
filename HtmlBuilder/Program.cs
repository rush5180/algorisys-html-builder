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
            Testing();
        }

        private static void Testing()
        {
            HtmlImage img = new HtmlImage();
            img.ImageSrc = "https://en.wikipedia.org/wiki/File:C_Sharp_wordmark.svg";
            img.Alt = "Logo";

            HtmlPara pr = new HtmlPara();
            pr.Text = "My paragraph";

            HtmlLink lnk = new HtmlLink();
            lnk.LinkSrc = "https://in.yahoo.com/";
            lnk.LinkText = "Yahooo!!";

            HtmlHeader head = new HtmlHeader();
            head.ContentString = "Heading";
            head.SizeOfString = 1;
            
            HtmlTable table = new HtmlTable();
            table.Rows = 3;
            table.Columns = 3;
          
            try
            {
                table.AddRowsToList("A","B", "C", "D", "E", "F");
            }
            catch (InvalidInputException iie)
            {
                P(iie.Message.ToString());
            }
            HtmlPage page = new HtmlPage();
            page.Title = "My fabulous page";
            page.BodyColor = "yellow";
            page.Elements.Add(head);
            page.Elements.Add(img);
            page.Elements.Add(pr);
            page.Elements.Add(lnk);
            page.Elements.Add(table);

            var html = page.GetPageHtml();
        }

        static void P(string s)
        {
            Console.WriteLine(s);
        }
        public static string ReadString(string msg)
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
