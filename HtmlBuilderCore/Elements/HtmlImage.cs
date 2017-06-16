using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilderCore.Elements
{
    public class HtmlImage : IHtmlElement
    {
        public string ImageSrc { get; set; }
        public string Alt { get; set; }

        public string GetHtmlString()
        {
            return string.Format("<img src='{0}' alt='{1}' />", this.ImageSrc, this.Alt);
        }
    }
}
