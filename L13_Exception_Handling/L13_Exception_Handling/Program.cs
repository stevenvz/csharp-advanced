using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13_Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("Steve");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
