using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLWriter
{
    class Body : HTMLContainer
    {
        string foreground;
        string background;

        public Body(List<IElement> children, string foreground = "#000000", string background = "#FFFFFF") : base("body", children) {
            this.foreground = foreground;
            this.background = background;
        }

        public override void RenderContent(int tabIndex, List<string> output)
        {
            output.Add(Utils.GetTabs(tabIndex) + "<" + Tag + " style=\"background-color: " + background + "; color: " + foreground + "\" >");

            Children.ForEach(obj => obj.RenderContent(tabIndex + 1, output));

            output.Add(Utils.GetTabs(tabIndex) + "</" + Tag + ">");
        }
    }
}
