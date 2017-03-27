using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace FRLGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //IGenericClass<string> object1 = new GenericClass<string>();
            //object1.GenericValue = "V60";
            //object1.StringValue = "String value that we choose";
            //Console.WriteLine($"object1 {object1.StringValue}");
            //Console.WriteLine($"object1 {object1.GenericValue}");

            //IGenericClass<int> object2 = new GenericClass<int>();
            //object2.GenericValue = 1243;
            //object2.StringValue = "String value that we choose";
            //Console.WriteLine($"object2 {object2.StringValue}");
            //Console.WriteLine($"object2 {object2.GenericValue}");

            IGenericClass<List<string>> object3 = new GenericClass<List<string>>();
            object3.GenericValue = new List<string> {"String1", "String2"};
            //object3.StringValue = "String value that we choose";
            //Console.WriteLine($"object3 {object3.StringValue}");

            //foreach (var value in object3.GenericValue)
            //{
            //    Console.WriteLine($"object3 {value}");
            //}

            var listString = new List<string>();
            var listInt = new List<int>();
            var genericMethodObject = new ClassWithGenericMethod();
            genericMethodObject.AddToList(listString, "string 1");
            genericMethodObject.AddToList(listString, "string 2");
            genericMethodObject.AddToList(listInt, 1);
            genericMethodObject.AddToList(listInt, 2);
            
            genericMethodObject.PrintListObjects(listString);
            genericMethodObject.PrintListObjects(listInt);
            
        }
    }
}
