/*1510601027 fhs38532
  Thomas Siller*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Decorator {
    abstract class StreamEncoderDecoder : Stream {
        Stream _stream;
        Boolean _decode;

        public StreamEncoderDecoder(Stream stream) {
            this._stream = stream;
        }

        public override bool CanRead
        {
            get
            {
                return this._stream.CanRead;
            }
        }

        public override bool CanSeek
        {
            get
            {
                return this._stream.CanSeek;
            }
        }

        public override bool CanWrite
        {
            get
            {
                return this._stream.CanWrite;
            }
        }

        public override long Length
        {
            get
            {
                return this._stream.Length;
            }
        }

        public override long Position
        {
            get
            {
                return this._stream.Position;
            }

            set
            {
                this._stream.Position = value;
            }
        }

        public override void Flush() {
            this._stream.Flush();
        }

        public override int Read(byte[] buffer, int offset, int count) {
            int result = this._stream.Read(buffer, offset, count);
            for(int i = 0; i < buffer.Length; i++) {
                buffer[i] = Encode(buffer[i]);
            }
            return result;
        }

        public override long Seek(long offset, SeekOrigin origin) {
            return this._stream.Seek(offset, origin);
        }

        public override void SetLength(long value) {
            this._stream.SetLength(value);
        }

        public override void Write(byte[] buffer, int offset, int count) {
            for(int i = 0; i < buffer.Length; i++) {
                buffer[i] = Decode(buffer[i]);
            }
            this._stream.Write(buffer, offset, count);
        }

        public abstract byte Encode(byte b);

        public abstract byte Decode(byte b);
    }
}