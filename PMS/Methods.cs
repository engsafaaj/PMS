using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS
{
   public class Methods
    {
        public MemoryStream ma = new MemoryStream();
        public byte[] ar;


        // return Memory Stream
        public MemoryStream Convert_Image()
        {
            ma = new MemoryStream(ar);
            return ma;
        }
        // return Byte
        public byte[] Convert_Byte()
        {
            return ma.ToArray();
        }
    }
}
