using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forkRepo
{
    static class Extention
    {
        public static IEnumerable<T> DeserializeObjectCollection<T>(this string str)
        {
            List<T> result = null;

            try
            {
                result = JsonConvert.DeserializeObject<List<T>>(str);
            }
            catch (JsonReaderException jrex)
            {
                throw jrex;
            }

            return result;
        }
    }
}
