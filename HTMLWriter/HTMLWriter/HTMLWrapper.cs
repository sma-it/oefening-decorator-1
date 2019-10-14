using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLWriter
{
    abstract class HTMLWrapper : IElement
    {
        string tag;
        public string Tag => tag;

        IElement child;
        public IElement Child => child;

        public HTMLWrapper(string tag, IElement child)
        {
            this.tag = tag;
            this.child = child;
        }

        public virtual void RenderContent(int tabIndex, List<string> output)
        {
            output.Add(Utils.GetTabs(tabIndex) + "<" + Tag + ">");
            Child.RenderContent(tabIndex + 1, output);
            output.Add(Utils.GetTabs(tabIndex) + "</" + Tag + ">");
        }
    }
}
