using System;
using System.Windows.Forms;
using ConvertCore;

namespace ImageToDxfConverter
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Run();
        }

        private static void Run()
        {
            using var model = ConverterModel.Create();
            Application.Run(new MainForm(model));
        }
    }
}
