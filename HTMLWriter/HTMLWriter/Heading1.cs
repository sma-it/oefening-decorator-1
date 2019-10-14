using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLWriter
{
    class Heading1 : HTMLContent
    {
        public Heading1(string content) : base("h1", content) { }
    }
}
