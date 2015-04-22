using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Užduotis1
{
    class StringTypeComparison
    {
        public StringTypeComparison()
        {

        }

        public bool CompareLowCaseExit(string first)
        {
            string exit = "exit";
            bool result = String.Equals(exit, first, StringComparison.Ordinal);
            return result;
        }

    }
}
