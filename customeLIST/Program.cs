using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customeLIST
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> testList = new CustomList<int>();
            testList.Add(12);
            testList.Add(13);
            testList.Remove(12);
            Console.ReadLine();


        }
    }
}
