using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Užduotis1;

namespace Užduotis1
{
    class Program
    {
        static void Main()
        {

            TextReader reader = new TextReader();
            StringTypeComparison compare = new StringTypeComparison();
            MessageChecker message = new MessageChecker();
            UserInterface ui = new UserInterface();
            List<Properties> file = reader.TextReading();

            ui.Communicating(file, compare, message);

        }

    }
}
