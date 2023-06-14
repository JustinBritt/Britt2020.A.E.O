namespace Britt2022.A.E.O.Factories.Solutions
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.Solutions;
    using Britt2022.A.E.O.Interfaces.Solutions;
    using Britt2022.A.E.O.InterfacesFactories.Solutions;

    internal sealed class WGPMSolutionFactory : IWGPMSolutionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WGPMSolutionFactory()
        {
        }

        public IWGPMSolution Create()
        {
            IWGPMSolution instance = null;

            try
            {
                instance = new WGPMSolution();
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