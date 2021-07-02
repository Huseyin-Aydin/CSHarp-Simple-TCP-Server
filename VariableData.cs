using System.Net;
using System.Net.Sockets;
namespace TCP_Server
{
    class VariableData
    {
        public byte[] message;
        public string hostAddr = "localhost";
        public short portAddr = 110;
        public string strData = null;
        public byte[] bytes = null;
        public IPHostEntry host;
        public IPAddress ip;
        public IPEndPoint IPEndPoint;
        public Socket SocListener;
        public VariableData() {
            host = Dns.GetHostEntry(hostAddr);
            ip = host.AddressList[0];
            IPEndPoint = new IPEndPoint(ip, portAddr);
            SocListener = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        }
    }
}
