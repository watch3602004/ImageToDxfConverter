using System.Drawing;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace ConvertCore
{
    internal class WrappedImage : IWrappedImage
    {
        private readonly Mat _original;
        private readonly Mat _current;
        private readonly Bitmap _bitmap;

        public static WrappedImage Create(string path, int threshold)
        {
            return new(path, threshold);
        }

        private WrappedImage(string path, int threshold)
        {
            _original = new Mat(path, ImreadModes.Grayscale);
            _current = _original.Threshold(threshold, 255, ThresholdTypes.Binary);
            _bitmap = _current.ToBitmap();
        }

        public Bitmap GetBitmap()
        {
            return _bitmap;
        }

        public Bitmap GetBinImage(int threshold)
        {
            Cv2.Threshold(_original, _current, threshold, 255, ThresholdTypes.Binary);
            _current.ToBitmap(_bitmap);
            return _bitmap;
        }

        public IDxfData GetDxf(LinePitch linePitch)
        {
            return _bitmap.ConvertToDxf(linePitch);
        }

        public void Dispose()
        {
            using (_original) { }
            using (_current) { }
            using (_bitmap) { }
        }
    }
}