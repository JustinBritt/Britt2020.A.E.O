namespace Britt2020.A.E.O.Interfaces.Results.OverallWallTime
{
    using System;

    public interface IOverallWallTime
    {
        TimeSpan Value { get; }

        TimeSpan GetValueForOutputContext();
    }
}