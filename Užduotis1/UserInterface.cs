using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Užduotis1
{
    class UserInterface
    {

        public UserInterface()
        {

        }


        public void Communicating(List<Properties> file, StringTypeComparison compare, MessageChecker message)
        {            
            string code;
            do
            {

                Console.WriteLine("Įveskite komandą (exit to leave):");
                code = Console.ReadLine();
                messageSearch(code, file, compare, message);

            } while (!compare.CompareLowCaseExit(code));
        }

        private void messageSearch(string code, List<Properties> file, StringTypeComparison compare, MessageChecker message)
        {

            if (!compare.CompareLowCaseExit(code))
            {
                message.Message(code, file);
            }

        }

    }
}
