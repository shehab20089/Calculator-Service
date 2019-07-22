using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using CalculatorServiceLibrary;
using System.Threading.Tasks;

namespace SelfHosts
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(CalculatorService));
            host.Open();
            if (host.State == CommunicationState.Opened)
            {
                foreach (var endpoint in host.Description.Endpoints)
                {
                    Console.WriteLine(endpoint.ListenUri);

                }
                Console.WriteLine("to close press enter:D");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
