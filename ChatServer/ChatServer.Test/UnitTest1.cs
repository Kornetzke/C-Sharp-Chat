using System;
using ChatServer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;

namespace ChatServer.Test
{
    [TestClass]
    public class UnitTest1
    {

        IMessenger messenger;

        [TestInitialize]
        public void Init()
        {
            messenger = new Messenger(100);
        }

        [TestMethod]
        public void TestMethod1()
        {
            string expectedMessage = "Hello";
            byte[] byteMessage = NetHelper.ConvertMessage(expectedMessage);
            byte[] buffer = new byte[100];
            Stream stream = new MemoryStream(NetHelper.ConvertMessage("Hello"));
            StreamWriter writer = new StreamWriter(stream);
            StreamReader reader = new StreamReader(stream);
            writer.AutoFlush = true;
            //writer.WriteLine("Hello");
            string actual = reader.ReadLine();
            stream.Write(byteMessage, 0, byteMessage.Count());
            stream.Flush();
            int bi = stream.Read(buffer, 0, buffer.Count());
            string actualMessage = messenger.GetMessage(stream);

            Assert.AreEqual(expectedMessage, actualMessage);
            StringAssert.Equals(expectedMessage, actualMessage);
        }
    }
}
