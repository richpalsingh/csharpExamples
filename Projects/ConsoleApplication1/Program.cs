using CSharpExamples.Examples.Amazon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringAndArrays stringAndArrays = new StringAndArrays();
            stringAndArrays.ReverseWordsInAString_SecondTry();

            Console.ReadLine();
        }
    }
}
