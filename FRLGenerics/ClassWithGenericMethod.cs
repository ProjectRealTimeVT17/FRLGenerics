using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRLGenerics
{
    class ClassWithGenericMethod
    {
        public List<T> AddToList<T>(List<T> list, T value)
        {
            list.Add(value);
            return list;
        }

        public void PrintListObjects<T>(List<T> list) where T:struct
        {
            foreach (var listObj in list)
            {
                Console.WriteLine($"Object: {listObj}");
            }
        }

        public void PrintListObjects(List<string> list)
        {
            foreach (var listObj in list)
            {
                Console.WriteLine($"Object: {listObj}");
            }
        }
    }
}
