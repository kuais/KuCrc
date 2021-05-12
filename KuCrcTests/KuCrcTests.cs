using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace Ku.Tests
{
    [TestClass()]
    public class KuCrcTests
    {
        [TestMethod()]
        public void InitTableTest()
        {
            KuCrc crc = new KuCrc(KuCrc.CrcType.CRC32);
            crc.InitTable();
        }

        [TestMethod()]
        public void CrcTest()
        {
            byte[] input = Encoding.ASCII.GetBytes("1234567");
            KuCrc crc = new KuCrc(KuCrc.CrcType.CRC32);
            //KuCrc crc = new KuCrc();
            //crc.config.Poly = 0x1021;
            //crc.config.Offset = 0x1D0F;
            //crc.config.XorOut = 0x1234;
            //crc.config.Offset = 0x0000;
            //crc.config.ReflectIn = false;
            //crc.config.ReflectOut = false;
            byte[] vs = crc.ComputeHash(input);
        }
    }
}