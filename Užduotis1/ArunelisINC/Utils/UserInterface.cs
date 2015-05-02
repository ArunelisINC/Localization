using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Užduotis1.ArunelisINC;
using Užduotis1.ArunelisINC.Utils;
using Užduotis1.ArunelisINC.File;
using Užduotis1.ArunelisINC.Message;

namespace Užduotis1.ArunelisINC.Utils
{
    class UserInterface
    {
        private List<Properties> properties;
        private ExitCommandChecker compare;
        private MessageChecker message;
        private AtributeSpliter atributeSpliter;

        public UserInterface(List<Properties> properties)
        {
            this.properties = properties;
            this.compare = new ExitCommandChecker();
            this.message = new MessageChecker();
            this.atributeSpliter = new AtributeSpliter();
        }

        public void Communicate()
        {            
            string code;
            do
            {
                Console.WriteLine("Įveskite komandą (exit to leave):");
                code = Console.ReadLine();
                string[] atributes = atributeSpliter.SeperateAtributes(code);
                code = atributes[0];
                initiateMessageSearch(code, atributes);
            } while (!compare.CompareExitCommand(code));
        }


        private void initiateMessageSearch(string code, string[] atributes)
        {

            if (!compare.CompareExitCommand(code))
            {
                message.FindMessage(code, properties, atributes);
            }

        }
    }
}
