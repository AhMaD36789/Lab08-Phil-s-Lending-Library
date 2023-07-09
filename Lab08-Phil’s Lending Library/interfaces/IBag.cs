using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab08_Phil_s_Lending_Library.Program;
using Lab08_Phil_s_Lending_Library.Classes;
using Lab08_Phil_s_Lending_Library.interfaces;

namespace Lab08_Phil_s_Lending_Library.interfaces
{
    public interface IBag<T> : IEnumerable<T>
    {
        /// <summary>
        /// Add an item to the bag. <c>null</c> items are ignored.
        /// </summary>
        void Pack(T item);

        /// <summary>
        /// Remove the item from the bag at the given index.
        /// </summary>
        /// <returns>The item that was removed.</returns>
        T Unpack(int index);
    }
}