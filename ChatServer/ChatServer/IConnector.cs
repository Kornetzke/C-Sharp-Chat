using System.IO;

namespace ChatServer
{
    public interface IConnector
    {
        bool IsConnected { get; }
        void Connect();
        void Close();
        Stream GetStream();
    }
}