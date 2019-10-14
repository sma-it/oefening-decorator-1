using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLWriter
{
    abstract class HTMLContainer : IElement
    {
        string tag;
        public string Tag => tag;

        List<IElement> wrappedObjects;
        public List<IElement> WrappedObjects => wrappedObjects;

        public HTMLContainer(string tag, List<IElement> wrappedObjects)
        {
            this.tag = tag;
            this.wrappedObjects = wrappedObjects;
        }

        public virtual void RenderContent(int tabIndex, List<string> output)
        {
            output.Add(Utils.GetTabs(tabIndex) + "<" + Tag + ">");

            WrappedObjects.ForEach(obj => obj.RenderContent(tabIndex + 1, output));

            output.Add(Utils.GetTabs(tabIndex) + "</" + Tag + ">");
        }
    }
}
