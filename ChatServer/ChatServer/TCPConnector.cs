using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    public class TCPConnector : IConnector
    { 
    IPAddress ipAddress;
    IPEndPoint remoteEP;

    // Create a TCPC.
    TcpClient client;
    public bool IsConnected { get { return client != null && client.Connected; } }

    public TCPConnector(string ip, int port)
    {
            ipAddress = new IPAddress(NetHelper.ConvertMessage(ip));
            remoteEP = new IPEndPoint(ipAddress, port);
            client = new TcpClient(remoteEP);
    }
        
    public void Close()
    {
            client.Close();
            client = null;
    }

    public void Connect()
    {
            client.Connect(remoteEP);
    }

        public Stream GetStream()
        {
            return client.GetStream();
        }
    }
}
