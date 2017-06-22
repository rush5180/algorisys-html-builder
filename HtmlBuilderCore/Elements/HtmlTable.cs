using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilderCore.Elements
{
    public class HtmlTable : IHtmlElement
    {

        public int rows { get; set; }
        public int columns { get; set; }
        public string values { get; set; }
        public List<object> list { get; set; }
        int i, j;

        public HtmlTable()
        {
            list = new List<object>();
        }
        public string getTable = "";
        public void AddRow(params string[] rowdata)
        {
            if (rowdata.Length > (this.columns * this.rows))
            {
                throw new invalidInputException("Please Enter Valid Input");
            }
            else
            {
                int c = 0;
                for (i = 0; i < this.rows; i++)
                {
                    getTable += "<tr>";
                    for (j = 0; j < this.columns; j++)
                    {
                        // arr_table[i, j] = Console.ReadLine();
                        getTable += "<td>" + rowdata[c++] + "</td>";
                        //c++;
                    }
                    getTable += "</tr>";
                    list.Add(getTable);
                    //getTable = "";
                }

                foreach (object tableData in list)
                {
                    getTable += tableData;
                }

            }

        }
        public string GetHtmlString()
        {
            // string[,] arr_table = new string[this.rows, this.columns];


            // getTable += "</table>";

            return string.Format("<table border='1'>{0}</table>", this.getTable);
        }






    }
}
