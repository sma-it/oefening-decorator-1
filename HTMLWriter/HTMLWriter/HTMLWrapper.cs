using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLWriter
{
    abstract class HTMLWrapper : IElement
    {
        string tag;
        public string Tag => tag;

        IElement wrappedObject;
        public IElement WrappedObject => wrappedObject;

        public HTMLWrapper(string tag, IElement wrappedObject)
        {
            this.tag = tag;
            this.wrappedObject = wrappedObject;
        }

        public virtual void RenderContent(int tabIndex, List<string> output)
        {
            output.Add(Utils.GetTabs(tabIndex) + "<" + Tag + ">");
            WrappedObject.RenderContent(tabIndex + 1, output);
            output.Add(Utils.GetTabs(tabIndex) + "</" + Tag + ">");
        }
    }
}
