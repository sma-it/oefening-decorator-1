using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLWriter
{
    static class Utils 
    {
        public static string GetTabs(int amount)
        {
            string tabs = string.Empty;
            for (int i = 0; i < amount; i++)
            {
                tabs += "\t";
            }
            return tabs;
        }
    }
}
