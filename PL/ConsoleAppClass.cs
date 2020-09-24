using System;
using System.IO;
using BLL;

namespace PL
{
    public static class ConsoleAppClass
    {
        /* here goes everything that's 
        * connected to the interaction
        * with the user, e.g. through a Console
        */
        public static void Run(string[] args)
        {
            Console.WriteLine("This is an example of Console App");
            string path;
            if (args.Length == 0)
            {
                Console.WriteLine("Please, write the name/path of/to the file: ");
                path = (string)Console.In.ReadLine();
            } else {
                path = args[0];
            }
            string s2 = "fox"; //a word to find
            BllClass bl = new BllClass(path);
            bool b = bl.Contains(s2);
            Console.WriteLine("'{0}' is in the file '{1}': {2}",
                s2, path, b);
            if (b)
            {
                int index = bl.IndexOf(s2);
                if (index >= 0)
                    Console.WriteLine("'{0} begins at character position {1}",
                                  s2, index + 1);
            }
        }
    }
}
