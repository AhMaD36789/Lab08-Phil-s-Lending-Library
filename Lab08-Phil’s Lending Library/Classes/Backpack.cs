using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab08_Phil_s_Lending_Library.Program;
using Lab08_Phil_s_Lending_Library.Classes;
using Lab08_Phil_s_Lending_Library.interfaces;

namespace Lab08_Phil_s_Lending_Library.Classes
{
    public class Backpack<T> : IBag<T>
    {
        private List<T> list;

        public Backpack()
        {
            list = new List<T>();
        }

        public void Pack(T item)
        {
            if (item == null)
            {
                return;
            }

            list.Add(item);
        }

        public T Unpack(int index)
        {
            var item = list[index];
            list.RemoveAt(index);
            return item;
        }

        public void print()
        {
            Console.WriteLine("whats in my backpack?");
            foreach (T elemant in list)
            {
                Console.WriteLine(elemant);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


}
