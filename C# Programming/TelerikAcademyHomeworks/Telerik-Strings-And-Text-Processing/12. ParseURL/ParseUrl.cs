/* Write a program that parses an URL address given in the format:

		and extracts from it the [protocol], [server] and [resource] elements. 
         For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
		[protocol] = "http"
		[server] = "www.devbg.org"
		[resource] = "/forum/index.php"
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ParseURL
{
    class ParseUrl
    {
        static void Main(string[] args)
        {
            string url = "http://www.devbg.org/forum/index.php";
            string protocol = string.Empty;
            string server = string.Empty;
            string resource = string.Empty;

            protocol = url.Substring(0,url.IndexOf(':'));
            server = url.Substring(url.IndexOf(':') + 3, url.IndexOf('/', url.IndexOf(':') + 3) - url.IndexOf(':') - 3);
            resource = url.Substring(url.IndexOf('/', url.IndexOf(':') + 3));

            Console.WriteLine("Protocol:" + protocol);
            Console.WriteLine("Server:" + server);
            Console.WriteLine("Resource: " + resource);
        }
    }
}
