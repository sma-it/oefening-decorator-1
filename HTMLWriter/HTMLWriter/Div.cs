using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLWriter
{
    class Div : HTMLWrapper
    {
        string foreground;
        string background;

        public Div(IElement child, string foreground = "#000000", string background = "#FFFFFF") : base("div", child) {
            this.foreground = foreground;
            this.background = background;
        }

        public override void RenderContent(int tabIndex, List<string> output)
        {
            output.Add(Utils.GetTabs(tabIndex) + "<" + Tag + " style=\"background-color: " + background + "; color: " + foreground + "\" >");
            Child.RenderContent(tabIndex + 1, output);
            output.Add(Utils.GetTabs(tabIndex) + "</" + Tag + ">");
        }
    }
}
