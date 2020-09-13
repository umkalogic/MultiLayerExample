using System;
using System.IO;
using BLL;

namespace PL
{
    public static class PlClass
    {
        /* here goes everything that's 
        * connected to the interaction
        * with the user, e.g. through a Console
        */
        public static void Run()
        {
            Console.WriteLine("This is an example of PL");
            Console.WriteLine("Please, write the name of the file: ");
            string path = (string)Console.In.ReadLine();
            string s2 = "fox";
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
