/*1510601027 fhs38532
  Thomas Siller*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator {
    class StreamRot13 : StreamEncoderDecoder {
        public StreamRot13(Stream stream, Boolean decode = false) : base(stream, decode) {
        }

        public override byte Encode(byte b) {
            if(b >= 'a' && b <= 'z') {
                if(b > 'm') {
                    return b -= 13;
                }
                else {
                    return b += 13;
                }
            }
            else if(b >= 'A' && b <= 'Z') {
                if(b > 'M') {
                    return b -= 13;
                }
                else {
                    return b += 13;
                }
            }
            return b;
        }

        public override byte Decode(byte b) {
            if(b >= 'a' && b <= 'z') {
                if(b > 'm') {
                    return b -= 13;
                }
                else {
                    return b += 13;
                }
            }
            else if(b >= 'A' && b <= 'Z') {
                if(b > 'M') {
                    return b -= 13;
                }
                else {
                    return b += 13;
                }
            }
            return b;
        }
    }
}
