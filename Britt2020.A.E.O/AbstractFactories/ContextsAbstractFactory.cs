namespace Britt2020.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Britt2020.A.E.O.Factories.Contexts;
    using Britt2020.A.E.O.InterfacesAbstractFactories;
    using Britt2020.A.E.O.InterfacesFactories.Contexts;

    internal sealed class ContextsAbstractFactory : IContextsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ContextsAbstractFactory()
        {
        }

        public IWGPMInputContextFactory CreateWGPMInputContextFactory()
        {
            IWGPMInputContextFactory factory = null;

            try
            {
                factory = new WGPMInputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IWGPMOutputContextFactory CreateWGPMOutputContextFactory()
        {
            IWGPMOutputContextFactory factory = null;

            try
            {
                factory = new WGPMOutputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}