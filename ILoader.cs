using System;

namespace CeresGL
{
    public interface ILoader
    {
        T? GetProc<T>(string name) where T: Delegate;
    }
}