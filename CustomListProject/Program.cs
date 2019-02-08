using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(4);
            list.Add(6);
            list.Add(24);
            list.Add(13);
            list.Add(1);
            list.Add(12);
            int c = list.Count;
            Console.WriteLine(c);
            list.Add(11);
            Console.WriteLine(list.Count);
            list.Remove(12);
        }
    }   
}
