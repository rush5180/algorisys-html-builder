using HtmlBuilderCore.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLBuilder_ConsoleUI
{
    public class ConsoleInputMethods
    {

        public static HtmlHeader HeaderSet()
        {
            HtmlHeader Header = new HtmlHeader();
            Header.ContentString = HtmlBuilder.
                Program.ReadString("Enter Header you want to add");

            Header.SizeOfString = Convert.
                ToInt32(HtmlBuilder.Program.ReadString("Enter Size of heading"));

            return Header;
        }

        public static HtmlImage HtmlImageInput()
        {
            HtmlImage Image = new HtmlImage();
            Image.ImageSrc = HtmlBuilder.Program.ReadString("Enter Your Image Source");
            Image.Alt = HtmlBuilder.Program.ReadString("Enter your alternate source,if the image cannot be displayed");

            return Image;
        }

        public static HtmlPara HtmlParaInput()
        {
            HtmlPara Para = new HtmlPara();
            Para.Text = HtmlBuilder.Program.ReadString("Enter your para text");

            return Para;
        }

        public static HtmlTable HtmlTableInput()
        {
            HtmlTable Table = new HtmlTable();
            Table.Columns = Convert.ToInt32(HtmlBuilder.Program.ReadString("Enter number of columns"));
            Table.Rows = Convert.ToInt32(HtmlBuilder.Program.ReadString("Enter number of Rows"));
            var x = HtmlBuilder.Program.ReadString("Enter Table values separated by ,");
            try
            {
                Table.FillData(x.Split(','));
            }catch (Exception iie)
            {
               HtmlBuilder.Program.P(iie.Message.ToString());
            }
            return Table;
        }

        public static HtmlLink HtmlLinkInput()
        {
            HtmlLink Link = new HtmlLink();
            Link.LinkText = HtmlBuilder.Program.ReadString("Enter Link Text");
            Link.LinkSrc = HtmlBuilder.Program.ReadString("Enter Source");

            return Link;
        }

        public static HtmlHr HtmlhrInput()
        {
            HtmlHr Hr = new HtmlHr();
            Hr.Color = HtmlBuilder.Program.ReadString("Enter the Colour of the Horizontal Line");

            return Hr;
        }
    }
}
