using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilderCore.Elements
{
    public class HtmlTable : IHtmlElement
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public List<object> RowsList { get; set; }
               
        public HtmlTable()
        {
            RowsList = new List<object>();
        }
        public string Singular = "";
        public void AddRowsToList(params string[] rowdata)
        {
            
            int i, j;
           
            if (rowdata.Length > (this.Columns * this.Rows))
            {
                throw new InvalidInputException("Please Enter Valid Input");
            }
            else
            {
                int c = 0;
                int RowDataLength = rowdata.Length;
                for (i = 0; i < this.Rows; i++)
                {
                    Singular += "<tr>";
                    for (j = 0; j < this.Columns; j++)
                    {
                        if (RowDataLength != 0)
                        {
                            Singular += "<td>" + rowdata[c++] + "</td>";
                            RowDataLength--;
                        }
                        else
                        {
                            Singular += "<td></td>";
                        }
                    }
                    Singular += "</tr>";
                    RowsList.Add(Singular);
                    Singular = "";
                }
            }
         }
        public string GetHtmlString()
        {
            foreach (object TableData in RowsList)
            {
                Singular += TableData;
            }
            return string.
                Format("<table border='1'>{0}</table>", this.Singular);
        }
    }
}
