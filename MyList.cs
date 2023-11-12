using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList_rec
{
    internal class MyList<T>
    {
        public Element<T> first;
        public void Insert(Element<T> dat)
        {
            if (first == null)
            {

                first = dat;
            }
            else 
            { 
            dat.next = first;
            first = dat;
            }
            

        }
        public Element<T> Find(T val)
        {
            Element<T> dat = first;
            while (!dat.Equals(null) && !dat.MyData.Equals(val)) dat = dat.next;
            return dat;
        }

        public void Remove(Element<T> dat)
        {
            Element<T> prev = first;
            while (!prev.next.Equals(null) && !prev.next.Equals(dat)) prev = prev.next;

            prev.next = dat.next;
        }

        public void bejar(Element<T>current)
        {
            Console.WriteLine(current.MyData);
            if (current.next!=null)
            {
                bejar(current.next);
            }
             
        }
    }
}
