using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _001_socket编程_TCP协议_客户端
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress ipaddress = IPAddress.Parse("192.168.1.145");
            EndPoint point = new IPEndPoint(ipaddress, 7788);
            tcpClient.Connect(point);

            byte[] data = new byte[1024];
            int length = tcpClient.Receive(data);

            string message = Encoding.UTF8.GetString(data,0,length);
            Console.WriteLine(message);

            //向服务器端发送消息
            string message2 = Console.ReadLine();
            tcpClient.Send(Encoding.UTF8.GetBytes(message2));


            Console.ReadKey();
        }
    }
}
