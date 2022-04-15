namespace Britt2022.A.E.O.Factories.ParameterElements.Surgeries
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Classes.ParameterElements.Surgeries;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.Surgeries;

    internal sealed class nParameterElementFactory : InParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public nParameterElementFactory()
        {
        }

        public InParameterElement Create(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement,
            PositiveInt value)
        {
            InParameterElement parameterElement = null;

            try
            {
                parameterElement = new nParameterElement(
                    iIndexElement,
                    ωIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameterElement;
        }
    }
}