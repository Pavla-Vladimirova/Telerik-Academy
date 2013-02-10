using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _04.DownloadFIleFromInternet
{
    class DownloadFIleFromInternet
    {
        static void Main(string[] args)
        {
            while (true)
            {
                WebClient file = new WebClient();
                Console.WriteLine("Write the path where you want to save the file");
                string path = Console.ReadLine();
                try
                {
                    file.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", path);
                    return;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("The address of the file you want to download is null");
                }
                catch (WebException)
                {
                    Console.WriteLine("The file name is empty,or the address of the file you want to download is invalid,or the file does not exist,or an error occurred while downloading data");
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("The invoked method is not supported");
                }
                finally
                {
                    file.Dispose();
                }
            }
        }
    }
}
