using System;

namespace ConvertCore
{
    public interface IDxfData : IDisposable
    {
        void Save(Func<string> func);
    }
}