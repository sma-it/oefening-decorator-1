using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLWriter
{
    abstract class HTMLContainer : IElement
    {
        string tag;
        public string Tag => tag;

        List<IElement> children;
        public List<IElement> Children => children;

        public HTMLContainer(string tag, List<IElement> children)
        {
            this.tag = tag;
            this.children = children;
        }

        public virtual void RenderContent(int tabIndex, List<string> output)
        {
            output.Add(Utils.GetTabs(tabIndex) + "<" + Tag + ">");

            Children.ForEach(obj => obj.RenderContent(tabIndex + 1, output));

            output.Add(Utils.GetTabs(tabIndex) + "</" + Tag + ">");
        }
    }
}
