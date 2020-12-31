using System;
using System.Drawing;

namespace ConvertCore
{
    internal interface IWrappedImage : IDisposable
    {
        Bitmap GetBitmap();
        Bitmap GetBinImage(int threshold);
        IDxfData GetDxf(LinePitch linePitch);
    }
}