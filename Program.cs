﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList_rec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            
            list.Insert(new Element<int>(23));
            list.Insert(new Element<int>(45));
            list.Insert(new Element<int>(12));
            list.bejar(list.first);

            Console.WriteLine();
            Console.WriteLine(list.Find(45).MyData); 

            list.Remove(list.Find(45));

            Console.WriteLine();
            list.bejar(list.first);

            Console.ReadKey();
        }
    }
}
