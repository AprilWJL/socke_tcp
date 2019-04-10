using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _053_socket编程_TCP协议_服务器端
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress ipaddress = new IPAddress(new byte[] { 192,168,1,145 });
            EndPoint point = new IPEndPoint(ipaddress, 7788);
            tcpServer.Bind(point);

            tcpServer.Listen(100);
            Console.WriteLine("开始监听");

            Socket clientSocket = tcpServer.Accept();
            Console.WriteLine("一个客户端连接");

            string message = "Hello";
            byte[] data = Encoding.UTF8.GetBytes(message);
            clientSocket.Send(data);
            Console.WriteLine("向客户端发送一条数据");

            byte[] data2 = new byte[1024];
            int length = clientSocket.Receive(data2);
            string message2 = Encoding.UTF8.GetString(data2, 0, length);
            Console.WriteLine("接收到了一条消息：" + message2);

            Console.ReadKey();
        }
    }
}
