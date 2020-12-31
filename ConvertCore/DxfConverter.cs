using System.Drawing;

namespace ConvertCore
{
    internal static class DxfConverter
    {
        public static IDxfData ConvertToDxf(this Bitmap bitmap, LinePitch linePitch)
        {
            var dxf = DxfData.CreateOpen();
            dxf.WriteRange(DxfStringGenerator.Header());
            dxf.WriteElements(bitmap, linePitch);
            dxf.WriteRange(DxfStringGenerator.Footer());
            dxf.Close();
            return dxf;
        }

        private static void WriteElements(this DxfData dxf, Bitmap bitmap, LinePitch linePitch)
        {
            for (var height = 0; height < bitmap.Height; height++)
            {
                ScanHorizontal(dxf, bitmap, linePitch, height);
            }
        }

        private static void ScanHorizontal(DxfData dxf, Bitmap bitmap, LinePitch linePitch, int height)
        {
            var width = 0;

            while (!IsOutOfWidthRange(bitmap, width))
            {
                if (IsPixelBlack(bitmap, width, height))
                {
                    var startX = linePitch.PitchMm() * (width - bitmap.Width / 2);
                    var startY = linePitch.PitchMm() * (-height + bitmap.Height / 2);
                    var line = new LineElement(startX, startY);

                    while (!IsOutOfWidthRange(bitmap, width) && IsPixelBlack(bitmap, width, height))
                    {
                        line.SetEndX(linePitch.PitchMm() * (width - bitmap.Width / 2));
                        width++;
                    }

                    dxf.WriteRange(DxfStringGenerator.GenerateLine(line));
                }

                width++;
            }
        }

        private static bool IsPixelBlack(Bitmap bitmap, int width, int height)
        {
            return (int)bitmap.GetPixel(width, height).GetBrightness() == 0;
        }

        private static bool IsOutOfWidthRange(Image bitmap, int width)
        {
            return bitmap.Width <= width;
        }
    }
}