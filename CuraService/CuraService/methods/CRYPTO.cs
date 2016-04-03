using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CuraService.methods
{
    class CRYPTO
    {
        ZBase32Encoder zBase32 = new ZBase32Encoder();

        public string encrypt(string Password)
        {           
            byte[] plntxtarr = Encoding.UTF8.GetBytes(Password);
            string cryptedpw = zBase32.Encode(plntxtarr);
            return cryptedpw;
        }

        public string decrypt(string PWORD)
        {
            byte[] decrptdpw = zBase32.Decode(PWORD);
            string decrpttxt = Encoding.UTF8.GetString(decrptdpw);
            return decrpttxt;
        }
    }
}
