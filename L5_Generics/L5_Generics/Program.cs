using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers =  new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var dictionary = new GenericsDictionary<string, Book>();
            dictionary.Add("1234", new Book());

            var number = new Nullable<int>();
            Console.WriteLine("Has value ?" + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
        }
    }
}
