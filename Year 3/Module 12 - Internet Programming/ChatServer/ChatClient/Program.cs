using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress iPAddress = ipHostInfo.AddressList[0];
            IPEndPoint remoteEndPoint = new IPEndPoint(iPAddress, 11000);

            Socket sender = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                sender.Connect(remoteEndPoint);
                Console.WriteLine($"Socket connected to {sender.RemoteEndPoint.ToString()}");

                while (true)
                {
                    string message = "";
                    do
                    {
                        Console.Write(">");
                        message = Console.ReadLine();
                    } while (message == "");

                    byte[] messageData = Encoding.ASCII.GetBytes(message + "<EOF>");

                    int bytesSent = sender.Send(messageData);

                    if(message == "exit")
                    {
                        break;
                    }
                }

                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
