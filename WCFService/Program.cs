using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFService
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost server = new ServiceHost(typeof(BookService));
            server.Open();

            Console.WriteLine("Your service is started...");
            Console.ReadLine();

            server.Close();
        }
    }
}
