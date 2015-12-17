using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            IGenericList<string> stringList = new GenericList<string>();
            stringList.Add("a");
            stringList.Add("b");
            stringList.Add("c");
            foreach (var l in stringList)
            {
                Console.WriteLine(l);
            }
            Console.ReadLine();
        }
    }
}
