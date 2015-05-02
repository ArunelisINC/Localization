using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Užduotis1.ArunelisINC.Utils;
using Užduotis1.ArunelisINC.File;
using Užduotis1.ArunelisINC.Message;

namespace Užduotis1.ArunelisINC.Utils
{


    class ExitCommandChecker
    {
        private const string EXIT_COMMAND = "EXIT";
        private const string EXIT_COMMAND1 = "Exit";
        private const string EXIT_COMMAND2 = "exit";


        public bool CompareExitCommand(string first)
        {
            bool result = String.Equals(EXIT_COMMAND, first, StringComparison.Ordinal);
            if (!result)
            {
                result = String.Equals(EXIT_COMMAND1, first, StringComparison.Ordinal);
            }
            else if (!result)
            {
                result = String.Equals(EXIT_COMMAND2, first, StringComparison.Ordinal);
            }
            return result;
        }

    }
}
