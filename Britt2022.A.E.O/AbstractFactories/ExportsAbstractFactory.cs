namespace Britt2022.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Factories.Exports;
    using Britt2022.A.E.O.InterfacesAbstractFactories;
    using Britt2022.A.E.O.InterfacesFactories.Exports;

    internal sealed class ExportsAbstractFactory : IExportsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExportsAbstractFactory()
        {
        }

        public IWGPMExportFactory CreateWGPMExportFactory()
        {
            IWGPMExportFactory factory = null;

            try
            {
                factory = new WGPMExportFactory();
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