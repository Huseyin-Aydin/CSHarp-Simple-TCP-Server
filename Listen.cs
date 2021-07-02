using System;
using System.Net.Sockets;
using System.Text;
namespace TCP_Server
{
    class Listen
    {
        public Listen(VariableData data)
        {
            data.SocListener.Bind(data.IPEndPoint);
            data.SocListener.Listen(30);
            Console.WriteLine("Clients Waiting..");
            Socket SocHandler = data.SocListener.Accept();
            while (true)
            {
                data.bytes = new byte[1024];
                int recBytes = SocHandler.Receive(data.bytes);
                data.strData += Encoding.ASCII.GetString(data.bytes, 0, recBytes);
                if (data.strData.IndexOf("<EOF>") > -1) break;
            }
            Console.WriteLine("Message : " + data.strData);
            data.message = Encoding.ASCII.GetBytes(data.strData);
            SocHandler.Send(data.message);
            SocHandler.Shutdown(SocketShutdown.Both);
            SocHandler.Close();

        }
    }
}
