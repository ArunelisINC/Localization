using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Užduotis1
{
    class FileDecoder
    {

        public FileDecoder()
        {

        }

        public List<Properties> Decoding(string[] lines)
        {
            List<Properties> file = new List<Properties>();

            foreach (string line in lines)
            {

                string[] split = line.Split('=');

                file.Add(new Properties()
                {
                    messageCode = split[0],
                    message = split[1]
                });

            }

            return file;

        }

    }
}
