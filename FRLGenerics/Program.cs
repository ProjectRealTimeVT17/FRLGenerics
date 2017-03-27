using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace FRLGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generic class exemple

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

            //IGenericClass<List<string>> object3 = new GenericClass<List<string>>();
            //object3.GenericValue = new List<string> { "String1", "String2" };
            //object3.StringValue = "String value that we choose";
            //Console.WriteLine($"object3 {object3.StringValue}");

            //foreach (var value in object3.GenericValue)
            //{
            //    Console.WriteLine($"object3 {value}");
            //}

            #endregion

            #region Generic method exemple

            //var listString = new List<string>();
            //var listInt = new List<int>();
            //var genericMethodObject = new ClassWithGenericMethod();
            //genericMethodObject.AddToList(listString, "string 1");
            //genericMethodObject.AddToList(listString, "string 2");
            //genericMethodObject.AddToList(listInt, 1);
            //genericMethodObject.AddToList(listInt, 2);

            //genericMethodObject.PrintListObjects(listString);
            //genericMethodObject.PrintListObjects(listInt); 

            #endregion

            #region Dictionary exemple

            //Dictionary<string, string> myLanguageDictionary = new Dictionary<string, string>();
            //myLanguageDictionary.Add("se", "Swedish");
            //myLanguageDictionary.Add("fr", "French");
            //myLanguageDictionary.Add("en", "English");

            //var myLanguageDictionary = new Dictionary<string, string>
            //{
            //    {"se", "Swedish"},
            //    {"fr", "French"},
            //    {"en", "English"}
            //};

            //var language = myLanguageDictionary["fr"];
            //Console.WriteLine(language);

            ////MAX Två uppslag; Ett för att kolla om Key finns
            //if (myLanguageDictionary.ContainsKey("gr"))
            //{
            //    var language2 = myLanguageDictionary["gr"];
            //    Console.WriteLine(language2);
            //}

            ////MAX Ett uppslag
            //var language3 = string.Empty;
            //if (myLanguageDictionary.TryGetValue("gr", out language3))
            //{
            //    Console.WriteLine(language3);
            //}

            //Console.WriteLine("KeyValuePair loop");
            //foreach (var lang in myLanguageDictionary)
            //{
            //    //Långsam
            //    Console.WriteLine(lang.Value);
            //}

            //Console.WriteLine("Key loop");
            //foreach (var lang in myLanguageDictionary.Keys)
            //{
            //    //Långsammare
            //    Console.WriteLine(myLanguageDictionary[lang]);
            //}

            //Console.WriteLine("Value loop");
            //foreach (var lang in myLanguageDictionary.Values)
            //{
            //    //Snabbast
            //    Console.WriteLine(lang);
            //}

            #endregion

            #region Generic Collection Interfaces

            //var personal = new Personal();
            //personal.Persons = new List<Person>();
            //personal.Persons.Add(new Person() {FirstName = "Bobby",LastName = "Spencer"});
            //personal.Persons.Add(new Person() { FirstName = "John", LastName = "Hellman" });

            var personal = new Personal
            {
                Persons = new List<Person>
                {
                    new Person() {FirstName = "Bobby", LastName = "Spencer"},
                    new Person() {FirstName = "John", LastName = "Hellman"}
                }
            };

            foreach (var p in personal)
            {
                Console.WriteLine(p.FirstName);
            }

            foreach (var p in personal.Persons)
            {
                Console.WriteLine(p.FirstName);
            }

            #endregion

            #region LINQ

            IEnumerable<Person> person = personal.Persons.Where(x => x.FirstName == "Bobby");
            foreach (var _person in person)
            {
                Console.WriteLine("LINQ result: " + _person.FirstName);
            }

            IList<Person> person2 = personal.Persons.Where(x => x.FirstName == "Bobby").ToList();
            Console.WriteLine("LINQ result: " + person2[0].FirstName);
         
            Person person3 = personal.Persons.FirstOrDefault(x => x.FirstName == "Bobby");
            Console.WriteLine("LINQ result: " + person3.FirstName);

            #endregion

        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Personal  : IEnumerable<Person>
    {
        public List<Person> Persons;

        public IEnumerator<Person> GetEnumerator()
        {
            return Persons.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
