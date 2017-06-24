using System;

namespace HtmlBuilderCore.Elements
{
    public class HtmlHr : IHtmlElement
    {
        public string Color { get; set; }

        public string GetHtmlString()
        {
            return string.Format("<hr style='border-color:{0}'>", this.Color);
        }
    }
}