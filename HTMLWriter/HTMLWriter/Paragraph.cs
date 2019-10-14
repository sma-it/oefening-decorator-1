using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLWriter
{
    class Paragraph : HTMLContent
    {
        public Paragraph(string content) : base("p", content) { }
    }
}
