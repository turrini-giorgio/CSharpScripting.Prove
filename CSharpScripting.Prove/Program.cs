using Microsoft.CodeAnalysis.CSharp.Scripting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharpScripting.Prove
{
    class Program
    {
        static void Main(string[] args)
        {
            var script = @"int Add(int x, int y) => x + y; Add(X,Y)";
            WriteLine("Hello");
            var result = CSharpScript.EvaluateAsync<int>(script, null, new Utile { X = 100, Y = 200, }).Result;
            WriteLine(result);
        }
    }
    public class Utile
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
