using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLWriter
{
    class Body : HTMLContainer
    {
        public Body(List<IElement> wrappedObjects) : base("body", wrappedObjects) { }
    }
}
