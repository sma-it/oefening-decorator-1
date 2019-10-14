using System;
using System.Collections.Generic;

namespace HTMLWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            IElement output = null;

            output = new Div(
                new Paragraph("Hello World")
            );

            // ***************
            // don't change the code below this line
            // ***************
            var menu = new SMUtils.Menu();
            menu.AddOption('1', "Show HTML Code in Terminal", () =>
            {
                // render our objects
                List<string> result = new List<string>();
                output.RenderContent(0, result);

                // show in terminal window
                result.ForEach(line => Console.WriteLine(line));
            });

            menu.AddOption('2', "Show Result in Browser", () =>
            {
                // render our objects
                List<string> result = new List<string>();
                output.RenderContent(0, result);

                // write all lines to a file
                System.IO.File.WriteAllLines("index.html", result);

                // open this file with the default browser
                System.Diagnostics.Process.Start("cmd", $"/c start index.html");
            });

            menu.Start();
        }
    }
}
