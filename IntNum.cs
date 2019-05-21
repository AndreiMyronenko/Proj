using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class IntNum : IInt
    {
        public List<int> Nums => Nums;

        public void Add(int n)
        {
            Nums.Add(n);
        }

        public void Remove(int n)
        {
            Nums.Remove(n);
        }
    }
}
