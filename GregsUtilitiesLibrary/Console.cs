using System;
using System.Collections.Generic;
using System.Text;


namespace GregsUtilitiesLibrary {
    class Console {

        public static void Print(string message) {
            System.Console.Writeline($"Gregs Print: {message}");        //Have to put System. event though we have imported it
        }
    }
}
