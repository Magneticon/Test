using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string m = "Test Program";
            Console.WriteLine(m);
            Console.WriteLine("");
            string F = m+Environment.NewLine;
            if (args.Length > 0){
                for (int i = 0; i < args.Length; i++){
                    m = "Parameter No."+(i+1)+" is: "+args[i];
                    F += Environment.NewLine+m;
                    Console.WriteLine(m);
                }
            }
            else{
                m = "No parameters were provided.";
                F += Environment.NewLine+m;;
                Console.WriteLine(m);
            }
            File.WriteAllText("output.txt", F);
        }
    }
}
