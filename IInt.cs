using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IInt
    {
        List<int> Nums { get; }
        void Add(int n);
        void Remove(int n);
    }
}
