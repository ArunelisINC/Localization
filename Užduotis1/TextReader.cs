using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Užduotis1
{
    class TextReader
    {

        public TextReader()
        {

        }


        public List<Properties> TextReading()
        {

            List<Properties> file = new List<Properties>();
            FileDecoder decoder = new FileDecoder();

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\aruna_000\Desktop\Projects\Užduotis\Props/message.properties.txt");

            file = decoder.Decoding(lines);

            return file;

        }

    }
}
