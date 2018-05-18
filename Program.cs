using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    class Program
    {

        // connecting part
        static void Main(string[] args)

        {
            Dictionary<IPAddress, TcpClient> clientsList = new Dictionary<IPAddress, TcpClient>();

            

            TcpListener listener = new TcpListener( 80);

            listener.Start(2);                    

            while (true)
            {
                Console.WriteLine("Waiting for a client");

                var iP1 = (object)(Console.ReadLine());

                IPAddress address = new IPAddress((long)iP1);

                TcpClient client = listener.AcceptTcpClient();

                clientsList.Add(address, client);
            }



        }



       
        



    }
}
