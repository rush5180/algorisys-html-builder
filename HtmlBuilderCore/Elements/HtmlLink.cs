using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilderCore.Elements
{
    public class HtmlLink : IHtmlElement
    {
        public string LinkText { get; set; }
        public string LinkSrc { get; set; }

        public string GetHtmlString()
        {
            return string.Format("<a href='{0}'>{1}</a>", this.LinkSrc, this.LinkText);
        }
    }
}
