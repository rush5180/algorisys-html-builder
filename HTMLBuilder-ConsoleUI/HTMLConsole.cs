using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlBuilderCore;
using HtmlBuilder;
using System.IO;
using HtmlBuilderCore.Elements;

delegate void HTMLHeaderDelegate();
namespace HTMLBuilder_ConsoleUI
{
   public class HTMLConsole
    {
        
        static void Main(string[] args)
        {
            HtmlPage page = new HtmlPage();
            HTMLConsole pr = new HTMLConsole();
            HtmlBuilder.Program.P("*****Welcome To HTMLBuilder*****");
            string FileName = HtmlBuilder.Program.ReadString("Enter File Name you want to create");
            StreamWriter CreatingFile=new StreamWriter("F://" +FileName+".html",true);
            page.Title = HtmlBuilder.Program.ReadString("Enter Page Title");
            page.BodyColor = HtmlBuilder.Program.ReadString("Enter Valid Color");
            bool x = true;
            while (x)
            {
                HtmlBuilder.Program.P("Options Available");
                HtmlBuilder.Program.P("1.To Add HTML Header\n2.To Add HTML Image\n3.To Add HTML Link\n4.To add HTML Table\n5.To Add HTML Para\n6.To Add Horizontal Line\n0.Exit");

                int Choice = Convert.ToInt32(HtmlBuilder.Program.ReadString("Enter your Choice"));

                Dictionary<int, Action> dict = new Dictionary<int, Action>();
                
                dict.Add(1, () => page.Elements.Add(ConsoleInputMethods.HeaderSet()));
                dict.Add(2, () => page.Elements.Add(ConsoleInputMethods.HtmlImageInput()));
                dict.Add(3, () => page.Elements.Add(ConsoleInputMethods.HtmlLinkInput()));
                dict.Add(4, () => page.Elements.Add(ConsoleInputMethods.HtmlTableInput()));
                dict.Add(5, () => page.Elements.Add(ConsoleInputMethods.HtmlParaInput()));
                dict.Add(6, () => page.Elements.Add(ConsoleInputMethods.HtmlhrInput()));
                dict.Add(0, () => {
                    x=false;
                    var test = page.GetPageHtml();
                    CreatingFile.WriteLine(test.ToString());
                    CreatingFile.Close();
                });

                dict[Choice]();
            }
        }
    }
}
