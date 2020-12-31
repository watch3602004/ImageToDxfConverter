using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToDxfConverter
{
    public partial class CancellationForm : Form
    {
        private readonly CancellationTokenSource _source = new();

        public static void Run(IWin32Window owner, Action action)
        {
            using var form = new CancellationForm(action);
            form.ShowDialog(owner);
        }

        private CancellationForm(Action action)
        {
            InitializeComponent();
            RunInner(action);
        }

        private async void RunInner(Action action)
        {
            await Task.Run(action, _source.Token);
            DialogResult = DialogResult.OK;
        }

        private void _buttonCancel_Click(object sender, EventArgs e)
        {
            _source.Cancel();
        }
    }
}
