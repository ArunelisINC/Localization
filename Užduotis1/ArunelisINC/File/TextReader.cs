using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Užduotis1.ArunelisINC.Utils;
using Užduotis1.ArunelisINC.File;
using Užduotis1.ArunelisINC.Message;

namespace Užduotis1.ArunelisINC.File
{
    class TextReader
    {

        public TextReader()
        {

        }


        public List<Properties> ReadText()
        {

            List<Properties> properties = new List<Properties>();
            PropertySpliter spliter = new PropertySpliter();

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\aruna_000\Desktop\Projects\Užduotis\Props/message.properties.txt");

            properties = spliter.SplitLines(lines);

            return properties;

        }

    }
}
