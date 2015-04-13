using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Užduotis1
{
    class Controller
    {




        internal static void message(string code, List<Properties> file)
        {

            Boolean messageExists = false;

            foreach (Properties prop in file )
            {
                if (prop.messageCode == code)
                {
                    Console.WriteLine(prop.message);
                    messageExists = true;
                }
            }

            if (!messageExists)
            {
                Console.WriteLine("Tokios žinutės nėra");
            }
        }
    }
}
