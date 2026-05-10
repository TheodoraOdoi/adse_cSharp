using System.IO;
namespace sess06_abstract_classes_and_interfaces
{

    public class IntelliSenseDemo : Stream
    {
        private byte[] buffer = new byte[1024];
        private int position = 0;

        public override bool CanRead => true;

        public override bool CanSeek => true;

        public override bool CanWrite => true;

        public override long Length => buffer.Length;

        public override long Position { get => position; set => position = (int)value; }

        public override void Flush()
        {
            // No implementation
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            int byteRead = Math.Min(count, buffer.Length - position);
            Array.Copy(buffer, position, buffer, offset, byteRead);
            position += byteRead;
            return byteRead;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            position = (int)offset;
            return position;
        }

        public override void SetLength(long value)
        {
            // No implementation
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            Array.Copy(array, offset, buffer, position, offset, count);
            position += count;
        }
    }
}
