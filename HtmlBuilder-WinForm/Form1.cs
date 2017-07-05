using HtmlBuilderCore;
using HtmlBuilderCore.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HtmlBuilder_WinForm
{
    public partial class Html_Builder_Winform : Form
    {
        public Html_Builder_Winform()
        {
            InitializeComponent();
        }
        HtmlPage page = new HtmlPage();
        HtmlTable table = new HtmlTable();

        private void Paragraph_Click(object sender, EventArgs e)
        {
            HtmlPara para = new HtmlPara();
            para.Text = Txt_Paragraph.Text;
            page.Elements.Add(para);
            Txt_Paragraph.Clear();
        }

        private void Image_Click(object sender, EventArgs e)
        {
            HtmlImage img = new HtmlImage();
            img.ImageSrc = Txt_Image.Text;
            page.Elements.Add(img);
            Txt_Image.Clear();
        }

        private void Link_click(object sender, EventArgs e)
        {
            HtmlLink lnk = new HtmlLink();
            lnk.LinkSrc = Txt_Link.Text;
            lnk.LinkText = Txt_Link_Text.Text;
            page.Elements.Add(lnk);
            Txt_Link.Clear();
            Txt_Link_Text.Clear();
        }

        private void Table_click(object sender, EventArgs e)
        {
            HtmlTable tab = new HtmlTable();

            tab.Rows = Convert.ToInt32(Txt_Number_Of_Rows.Text);
            tab.Columns = Convert.ToInt32(Txt_Number_Of_Columns.Text);
            string[] data = (Txt_Table_Data.Text).Split(',');
            tab.FillData(data);
            page.Elements.Add(tab);
            Txt_Number_Of_Rows.Clear();
            Txt_Number_Of_Columns.Clear();
            Txt_Table_Data.Clear();
           
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            page.Title = Txt_Title.Text;
            page.BodyColor = Txt_Bg_Colour.Text;
        }

        private void Create_page_Click(object sender, EventArgs e)
        {
            var html = page.GetPageHtml();
            string path = @"C:\Users\tek3\Desktop\HtmlBuilder8.htm";

            // Create the file.
            using (FileStream fs = File.Create(path, 1024))
            {
                StreamWriter writer = new StreamWriter(fs);
                writer.WriteLine(html.ToString());
                writer.Close();
            };
        }
    }
}