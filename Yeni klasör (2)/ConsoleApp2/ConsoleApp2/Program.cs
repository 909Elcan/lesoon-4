using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

          var hostEntry = await Dns.GetHostEntryAsync("www.Google.com");
            Console.WriteLine($"Host {hostEntry.HostName}");
            foreach (var ip in hostEntry.AddressList)
            {
                Console.WriteLine($"IP Address: {ip}");
            }

        }
    }
}
