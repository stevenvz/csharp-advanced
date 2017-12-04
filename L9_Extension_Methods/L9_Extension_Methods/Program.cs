using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace L9_Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long post blah blah blah";
            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);
        }
    }
}
