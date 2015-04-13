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

            List<Properties> file = Reading.reading();


            string code;
            do
            {
                Console.WriteLine("Įveskite komandą (exit to leave):");
                code = Console.ReadLine();
                Controller.message(code, file);

                if (code != "exit")
                {
                    Console.Read();
                }

                Console.Clear();

            } while (code != "exit");

        }
    }
}
