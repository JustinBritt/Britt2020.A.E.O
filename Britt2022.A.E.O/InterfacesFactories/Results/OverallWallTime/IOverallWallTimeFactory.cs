namespace Britt2022.A.E.O.InterfacesFactories.Results.OverallWallTime
{
    using System;

    using Britt2022.A.E.O.Interfaces.Results.OverallWallTime;

    public interface IOverallWallTimeFactory
    {
        IOverallWallTime Create(
            TimeSpan value);
    }
}