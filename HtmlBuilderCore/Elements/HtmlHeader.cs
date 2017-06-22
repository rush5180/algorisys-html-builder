using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilderCore.Elements
{
    public class HtmlHeader : IHtmlElement
    {

        public string content_string { get; set; }

        public int size_Of_string { get; set; }



        public string GetHtmlString()
        {
            return string.Format("<h" + this.size_Of_string + ">{0}</h" + this.size_Of_string + ">", this.content_string);
        }

    }
}
