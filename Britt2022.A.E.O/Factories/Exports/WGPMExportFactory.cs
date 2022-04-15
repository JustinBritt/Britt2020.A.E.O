namespace Britt2022.A.E.O.Factories.Exports
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.Exports;
    using Britt2022.A.E.O.Interfaces.Exports;
    using Britt2022.A.E.O.InterfacesFactories.Exports;

    internal sealed class WGPMExportFactory : IWGPMExportFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WGPMExportFactory()
        {
        }

        public IWGPMExport Create()
        {
            IWGPMExport export = null;

            try
            {
                export = new WGPMExport();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return export;
        }
    }
}