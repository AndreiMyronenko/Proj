using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    interface StringList : IEnumerable<string>
    {
        void Add(string line);
        void Delete(string line);
        void Sort();
    }
}
