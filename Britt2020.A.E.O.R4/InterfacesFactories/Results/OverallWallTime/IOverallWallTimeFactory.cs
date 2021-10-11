namespace Britt2020.A.E.O.InterfacesFactories.Results.OverallWallTime
{
    using System;

    using Britt2020.A.E.O.Interfaces.Results.OverallWallTime;

    public interface IOverallWallTimeFactory
    {
        IOverallWallTime Create(
            TimeSpan value);
    }
}