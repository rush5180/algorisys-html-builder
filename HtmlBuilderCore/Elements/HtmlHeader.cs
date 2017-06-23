using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilderCore.Elements
{
    public class HtmlHeader : IHtmlElement
    {
        public string ContentString { get; set; }
        public int SizeOfString { get; set; }

        public string GetHtmlString()
        {
            return string.Format("<h" + this.SizeOfString + ">{0}</h" + this.SizeOfString + ">", this.ContentString);
        }

    }
}
