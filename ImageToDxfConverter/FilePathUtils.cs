using System.Windows.Forms;

namespace ImageToDxfConverter
{
    public static class FilePathUtils
    {
        private const string ImageFilter = "Image File (*.bmp,*.jpg,*.png,*.tif)|*.bmp;*.jpg;*.png;*.tif|Bitmap(*.bmp)|*.bmp|Jpeg(*.jpg)|*.jpg|PNG(*.png)|*.png";
        private const string DxfFilter = "DXF File (*.dxf)|*.dxf";

        public static string GetSelectedImagePath()
        {
            using var dialog = new OpenFileDialog { Filter = ImageFilter };
            return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : string.Empty;
        }

        public static string GetSaveDxfPath()
        {
            using var dialog = new SaveFileDialog { Filter = DxfFilter };
            return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : string.Empty;
        }
    }
}