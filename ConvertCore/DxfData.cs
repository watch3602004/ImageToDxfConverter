using System;
using System.Collections.Generic;
using System.IO;

namespace ConvertCore
{
    internal class DxfData : IDxfData
    {
        private readonly StreamWriter _writer;
        private readonly string _tmpPath = Path.GetTempFileName();

        public static DxfData CreateOpen()
        {
            return new();
        }

        private DxfData()
        {
            _writer = new StreamWriter(_tmpPath, false);
        }

        public void WriteRange(IEnumerable<string> data)
        {
            foreach (var line in data)
            {
                _writer.WriteLine(line);
            }
        }

        public void Close()
        {
            _writer.Close();
        }

        public void Save(Func<string> func)
        {
            var output = func();
            if (string.IsNullOrEmpty(output)) return;
            if (File.Exists(output)) File.Delete(output);
            File.Move(_tmpPath, output);
            DeleteTmpIfExists();
        }

        private void DeleteTmpIfExists()
        {
            if (File.Exists(_tmpPath)) File.Delete(_tmpPath);
        }

        public void Dispose()
        {
            using (_writer) { }
            DeleteTmpIfExists();
        }
    }
}