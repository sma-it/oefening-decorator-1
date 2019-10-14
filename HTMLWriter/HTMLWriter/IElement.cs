using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLWriter
{
    interface IElement
    {
        void RenderContent(int tabIndex, List<string> output);
    }
}
