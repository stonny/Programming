/* Write a program that downloads a file from Internet
 * (e.g. http://www.devbg.org/img/Logo-BASD.jpg)
 * and stores it the current directory. Find in Google 
 * how to download files in C#. Be sure to catch all 
 * exceptions and to free any used resources in the finally block.
*/
namespace _04.DownloadFile
{
    using System;
    using System.Linq;
    using System.Net;

    class DownloadFile
    {
        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();
            try
            {
                webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "../../logo.jpg");
            }

            catch (WebException we)
            {
                Console.Error.WriteLine(we.Message);
            }

            catch (NotSupportedException nse)
            {
                Console.Error.WriteLine(nse.Message);
            }
            finally
            {
                webClient.Dispose();
            }

        }
    }
}
