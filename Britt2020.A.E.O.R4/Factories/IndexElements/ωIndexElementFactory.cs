namespace Britt2020.A.E.O.Factories.IndexElements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Classes.IndexElements;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.InterfacesFactories.IndexElements;

    internal sealed class ωIndexElementFactory : IωIndexElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ωIndexElementFactory()
        {
        }

        public IωIndexElement Create(
            PositiveInt value)
        {
            IωIndexElement indexElement = null;

            try
            {
                indexElement = new ωIndexElement(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return indexElement;
        }
    }
}