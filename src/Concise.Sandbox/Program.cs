using System;
using Concise.Core;

namespace Concise.Sandbox
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            10.Times((i) => "10 Times-Basic: {0}".FormatTo(i.ToString())
                .WriteLine());

            "".WriteLine();

            100.To(105, (i) => "100-105 To-Basic: {0}".FormatTo(i.ToString())
                .WriteLine());

            "".WriteLine();

            1000.To(1500,
                ((i) => "1000-1500 To-Incrementor: {0}".FormatTo(i.ToString())
                    .WriteLine()), 50);

            Console.ReadLine();
        }
    }
}
