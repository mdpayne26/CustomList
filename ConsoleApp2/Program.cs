using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Arrange
            //CustomList<int> custom = new CustomList<int>();
            //int value = 3;
            //int expectedResult = 1;
            ////Act
            //custom.Add(value);
            //Console.WriteLine(custom.Count);
            //List<int> list = new List<int>();
            //list.Add(2);
            //list.Add(4);
            //list.Add(6);
            //list.Add(24);
            //list.Add(13);
            //list.Add(1);
            //list.Add(12);

            CustomList<int> custom = new CustomList<int>();
            //custom.Add(1);
            //custom.Add(2);
            //custom.Add(3);
            //custom.Add(4);
            //custom.Add(5);
            //custom.Add(6);
            custom.Add(7);
            custom.Add(8);
            custom.Add(9);
            custom.Add(10);
            custom.Remove(10);
            //custom.Remove(9);


        }

    }
}
