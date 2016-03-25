using System.IO;

namespace ChatServer
{
    public interface IMessenger
    {
        void SendMessage(Stream stream, string message);
        string GetMessage(Stream stream);
    }
}