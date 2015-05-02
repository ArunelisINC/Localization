using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Užduotis1.ArunelisINC.Utils;
using Užduotis1.ArunelisINC.File;
using Užduotis1.ArunelisINC.Message;

namespace Užduotis1.ArunelisINC.Message
{
    class AtributeSpliter
    {

        public string[] SeperateAtributes(string code){

            string[] atributes = code.Split(' ');
            return atributes;

        }


    }
}
