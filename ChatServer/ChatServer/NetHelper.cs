using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    public static class NetHelper
    {
        public static Byte[] ConvertMessage(string message)
        {
            return Encoding.ASCII.GetBytes(message);
        }
        public static string ConvertMessage(byte[] message)
        {
            return Encoding.ASCII.GetString(message);
        }
    }
}
