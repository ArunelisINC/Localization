using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Užduotis1.ArunelisINC.Utils;
using Užduotis1.ArunelisINC.File;
using Užduotis1.ArunelisINC.Message;

namespace Užduotis1.ArunelisINC.Message{
    class PropertySpliter
    {

        public List<Properties> SplitLines(string[] lines)
        {
            List<Properties> properties = new List<Properties>();

            foreach (string line in lines)
            {

                string[] split = line.Split('=');

                properties.Add(new Properties()
                {
                    messageCode = split[0],
                    message = split[1]
                });

            }

            return properties;

        }

    }
}
