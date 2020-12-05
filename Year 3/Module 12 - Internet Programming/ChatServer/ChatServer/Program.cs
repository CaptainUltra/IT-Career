using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get host info
            string hostName = Dns.GetHostName();
            IPHostEntry ipHostInfo = Dns.GetHostEntry(hostName);
            IPAddress iPAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(iPAddress, 11000);

            //Create socket
            Socket listener = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                byte[] buffer = new byte[1024];

                listener.Bind(localEndPoint);
                listener.Listen(100);

                Socket handle = listener.Accept();

                while (true)
                {
                    string message = "";

                    while (true)
                    {
                        int messageData = handle.Receive(buffer);

                        message += Encoding.ASCII.GetString(buffer, 0, messageData);

                        if(message.Contains("<EOF>"))
                        {
                            message = message.Replace("<EOF>", "");
                            break;
                        }
                    }

                    Console.WriteLine(">" + message);

                    if (message == "exit")
                    {
                        handle.Shutdown(SocketShutdown.Both);
                        handle.Close();
                        break;
                    }
                }
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);
            }

            Console.Clear();
            Console.WriteLine("Goodbye!");
            Console.ReadKey(true);
        }
    }
}
