# CRC计算库
# 使用说明

byte[] input = Encoding.ASCII.GetBytes("1234567");  
KuCrc crc = new KuCrc(KuCrc.CrcType.CRC32);  
byte[] output = crc.ComputeHash(input);         // output 即为Crc32计算出来的值  
