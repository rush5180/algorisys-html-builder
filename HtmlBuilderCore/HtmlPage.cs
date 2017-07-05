using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilderCore
{
    public class HtmlPage
    {
        public HtmlPage()
        {
            this.Elements = new List<IHtmlElement>();
        }
        public string Title { get; set; }
        public string BodyColor { get; set; }

        public List<IHtmlElement> Elements { get; set; }

        public string GetPageHtml()
        {
            var bodyHtml = "";
            foreach (var element in this.Elements)
            {
                bodyHtml += element.GetHtmlString();
            }
            return string.Format("<html><head><title>{0}</title></head><body style ='background-color: {1}'>{2}</body></html>", 
                this.Title, 
                this.BodyColor, 
                bodyHtml);
        }
    }
}
