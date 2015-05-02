using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Užduotis1.ArunelisINC.Utils;
using Užduotis1.ArunelisINC.File;
using Užduotis1.ArunelisINC.Message;

namespace Užduotis1.ArunelisINC.Message
{
    class MessageChecker
    {

        public void FindMessage(string code, List<Properties> properties, string[] atributes)
        {

            Boolean messageExists = false;

            foreach (Properties prop in properties )
            {
                if (prop.messageCode == code)
                {
                    PrintAnswer(atributes, prop);
                    
                    messageExists = true;
                }
            }

            if (!messageExists)
            {
                Console.WriteLine("Tokios žinutės nėra");
            }
        }

        private void PrintAnswer(string[] atributes, Properties prop)
        {
            Console.Write(prop.message);
            if (atributes[1] != null)
            {
                Console.Write(" Pirmasis atributas " + atributes[1]);
            }
            else
            {
                Console.Write(" Pirmojo atributo nėra ");
            }
            if (atributes[1] != null)
            {
                Console.WriteLine(" Antrasis atributas " + atributes[2]);
            }
            else
            {
                Console.Write(" Antrojo atributo nėra ");
            }
        }

    }
}
