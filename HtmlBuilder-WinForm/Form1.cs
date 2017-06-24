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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        HtmlPage page = new HtmlPage();

     
      //  HtmlLink lnk = new HtmlLink();
        HtmlTable table = new HtmlTable();


        private void button1_Click(object sender, EventArgs e)
        {
            page.Title = textBox1.Text;
            //para.Text = richTextBox1.Text;
          //  img.ImageSrc = textBox2.Text;
         //   lnk.LinkSrc = textBox3.Text;
            //lnk.LinkText = textBox4.Text;
            table.Columns = Int32.Parse(textBox6.Text);
            table.Rows = Int32.Parse(textBox5.Text);
            string[] data = (textBox7.Text).Split(',');
            table.AddRowsToList(data);





          //  page.Elements.Add(img);
         //   page.Elements.Add(lnk);
           // page.Elements.Add(para);
            page.Elements.Add(table);

            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            var html = page.GetPageHtml();
            string path = @"C:\Users\tek3\Desktop\HtmlBuilder2.htm";

            // Create the file.
            using (FileStream fs = File.Create(path, 1024))
            {
                StreamWriter writer = new StreamWriter(fs);
                //   writer.WriteLine("<html><body><table border='2' width='200' height='300'><tr></tr></table></body></html>");

                writer.WriteLine(html.ToString());
                writer.Close();
            };

        }

        private void Paragraph_Click(object sender, EventArgs e)
        {
            HtmlPara para = new HtmlPara();
            para.Text = richTextBox1.Text;
            page.Elements.Add(para);
            richTextBox1.Clear();
        }

        private void Image_Click(object sender, EventArgs e)
        {
            HtmlImage img = new HtmlImage();
            img.ImageSrc = textBox2.Text;
            page.Elements.Add(img);
            textBox2.Clear();


        }

        private void Link_click(object sender, EventArgs e)
        {
            HtmlLink lnk = new HtmlLink();
            lnk.LinkSrc = textBox3.Text;
            lnk.LinkText = textBox4.Text;
            page.Elements.Add(lnk);

            textBox3.Clear();
            textBox4.Clear();
        }

      
    }
}