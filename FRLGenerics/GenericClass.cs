using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRLGenerics
{
    class GenericClass<T> : IGenericClass<T>
    {
        public string StringValue { get; set; }
        public T GenericValue { get; set; }

    }
}
