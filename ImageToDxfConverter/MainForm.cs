using System.IO;
using System.Windows.Forms;
using ConvertCore;

namespace ImageToDxfConverter
{
    public partial class MainForm : Form
    {
        private readonly ConverterModel _model;

        public MainForm(ConverterModel model)
        {
            InitializeComponent();
            _model = model;
        }

        private void _buttonReadImage_Click(object sender, System.EventArgs e)
        {
            ReadImage((int)_numericUpDownThreshold.Value);
        }

        private void ReadImage(int threshold)
        {
            var selected = FilePathUtils.GetSelectedImagePath();
            if (!File.Exists(selected)) return;
            _SelectedPath.Text = selected;
            _pictureBox.Image = _model.ReadImageFromPath(selected, threshold);
        }

        private void _buttonSaveDxf_Click(object sender, System.EventArgs e)
        {
            CancellationForm.Run(this, Convert);
            _model.SaveDxf(FilePathUtils.GetSaveDxfPath);
        }

        private void Convert()
        {
            _model.GenerateConverted(LinePitch.CreateFromUm((double)_numericLinePitch.Value));
        }

        private void _numericUpDownThreshold_ValueChanged(object sender, System.EventArgs e)
        {
            _pictureBox.Image = _model.GetBinImage((int)_numericUpDownThreshold.Value);
        }
    }
}
