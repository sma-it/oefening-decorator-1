using System;
using System.Collections.Generic;

namespace HTMLWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            IElement output = null;

            IElement nonsense = new Paragraph("Epsum factorial non deposit quid pro quo hic escorol. Olypian quarrels et gorilla congolium sic ad nauseum. Souvlaki ignitus carborundum e pluribus unum. Defacto lingo est igpay atinlay. Marquee selectus non provisio incongruous feline nolo contendre. Gratuitous octopus niacin, sodium glutimate. Quote meon an estimate et non interruptus stadium.");

            output = new Html(
                "My First Page",
                new Body(
                    // you can add lists with contents like this, but it's also posible to create a list first and insert it here
                    new List<IElement>() {
                        new Heading1("My First Page!"),
                        nonsense,
                        nonsense,
                        new Div(
                            new Paragraph("This is the end.")
                        )
                    }
                     
                )
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
