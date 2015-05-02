using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Užduotis1.ArunelisINC.Utils;
using Užduotis1.ArunelisINC.File;
using Užduotis1.ArunelisINC.Message;

namespace Užduotis1
{
    class Program
    {

        static void Main()
        {

            TextReader reader = new TextReader();
            List<Properties> properties = reader.ReadText();
            UserInterface ui = new UserInterface(properties);

            ui.Communicate();

        }

    }
}
