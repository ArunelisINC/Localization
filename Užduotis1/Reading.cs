using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Užduotis1
{
    class Reading
    {

        static public List<Properties> reading()
        {

            List<Properties> file = new List<Properties>();

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\aruna_000\Desktop\Projects\Užduotis\Props/message.properties.txt");

            foreach (string line in lines)
            {

                string[] split = line.Split('=');

                file.Add(new Properties()
                {
                    messageCode=split[0],
                    message=split[1]
                });

            }
            
            return file;

        }

    }
}
