namespace Britt2022.A.E.O.Factories.Results.OverallWallTime
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.Results.OverallWallTime;
    using Britt2022.A.E.O.Interfaces.Results.OverallWallTime;
    using Britt2022.A.E.O.InterfacesFactories.Results.OverallWallTime;

    internal sealed class OverallWallTimeFactory : IOverallWallTimeFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public OverallWallTimeFactory()
        {
        }

        public IOverallWallTime Create(
            TimeSpan value)
        {
            IOverallWallTime instance = null;

            try
            {
                instance = new OverallWallTime(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}