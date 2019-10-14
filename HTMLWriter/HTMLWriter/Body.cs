using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLWriter
{
    class Body : HTMLWrapper
    {
        public Body(IElement wrappedObject) : base("body", wrappedObject) { }
    }
}
