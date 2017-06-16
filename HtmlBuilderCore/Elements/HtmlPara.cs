using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilderCore.Elements
{
    public class HtmlPara : IHtmlElement
    {
        public string Text { get; set; }

        public string GetHtmlString()
        {
            return string.Format("<p>{0}</p>", this.Text);
        }
    }
}
