using System;
using System.Collections.Generic;
using System.Text;

namespace lccSuggestionCodeProject
{
    class lccSuggestionCodeProjectClass
    {
        static void Main(string[] lccALArgs)
        {
            int lccILoop = 0;
            Console.WriteLine("[main] STARTED, version: 20130710");
            for (lccILoop = 0; lccILoop < lccALArgs.Length; lccILoop++)
            {
                Console.WriteLine("[main] Arg Provided [" + lccALArgs[lccILoop]+"]");
            }
            Console.WriteLine("[main] DONE");
        }
    }
}
