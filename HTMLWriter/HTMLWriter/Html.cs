using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLWriter
{
    class Html : HTMLWrapper
    {
        string title;

        public Html(string title, IElement wrappedObject) : base("html", wrappedObject) {
            this.title = title;
        }

        public override void RenderContent(int tabIndex, List<string> output)
        {
            output.Add(Utils.GetTabs(tabIndex) + "<!DOCTYPE HTML>");
            output.Add(Utils.GetTabs(tabIndex) + "<html>");
            output.Add(Utils.GetTabs(tabIndex) + "<head>");
            output.Add(Utils.GetTabs(tabIndex) + "\t<title>" + title + "</title>");
            output.Add(Utils.GetTabs(tabIndex) + "</head>");

            WrappedObject.RenderContent(tabIndex + 1, output);

            output.Add(Utils.GetTabs(tabIndex) + "</html>");
        }
    }
}
