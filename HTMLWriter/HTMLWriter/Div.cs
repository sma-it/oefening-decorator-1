﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLWriter
{
    class Div : HTMLWrapper
    {
        public Div(IElement wrappedObject) : base("div", wrappedObject) { }
    }
}
