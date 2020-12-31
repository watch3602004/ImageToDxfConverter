using System.Drawing;

namespace ConvertCore
{
    internal class NullImage : IWrappedImage
    {
        private readonly Bitmap _nullBitmap = new(256, 256);

        public static NullImage Create()
        {
            return new();
        }

        private NullImage() { }

        public Bitmap GetBitmap()
        {
            return _nullBitmap;
        }

        public Bitmap GetBinImage(int threshold)
        {
            return _nullBitmap;
        }

        public IDxfData GetDxf(LinePitch linePitch)
        {
            return NullDxf.Create();
        }

        public void Dispose()
        {
            using (_nullBitmap) { }
        }
    }
}