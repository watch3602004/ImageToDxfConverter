using System;
using System.Drawing;

namespace ConvertCore
{
    public class ConverterModel : IDisposable
    {
        private IWrappedImage _image = NullImage.Create();
        private IDxfData _dxfData = NullDxf.Create();

        public static ConverterModel Create()
        {
            return new();
        }

        private ConverterModel() { }

        public Bitmap ReadImageFromPath(string path, int threshold)
        {
            _image = WrappedImage.Create(path, threshold);
            return _image.GetBitmap();
        }

        public Bitmap GetBinImage(int threshold)
        {
            return _image.GetBinImage(threshold);
        }

        public void GenerateConverted(LinePitch linePitch)
        {
            _dxfData = _image.GetDxf(linePitch);
        }

        public void SaveDxf(Func<string> func)
        {
            _dxfData.Save(func);
        }

        public void Dispose()
        {
            using (_image) { }
            using (_dxfData) { }
        }
    }
}