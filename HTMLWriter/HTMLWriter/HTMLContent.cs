using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLWriter
{
    abstract class HTMLContent : IElement
    {
        string tag;
        string content;

        public HTMLContent(string tag, string content)
        {
            this.tag = tag;
            this.content = content;
        }

        public void RenderContent(int tabIndex, List<string> output)
        {
            output.Add(Utils.GetTabs(tabIndex) + "<" + tag + ">");
            output.Add(Utils.GetTabs(tabIndex + 1) + content);
            output.Add(Utils.GetTabs(tabIndex) + "</" + tag + ">");
        }

    }
}
