using System;

namespace ConvertCore
{
    internal class NullDxf : IDxfData
    {
        public static NullDxf Create()
        {
            return new();
        }

        private NullDxf() { }
        public void Save(Func<string> func) { }
        public void Dispose() { }
    }
}