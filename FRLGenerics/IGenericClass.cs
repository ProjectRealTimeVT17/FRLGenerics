using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRLGenerics
{
    interface IGenericClass<T>
    {

        string StringValue { get; set; }
         T GenericValue { get; set; }

    }
}
