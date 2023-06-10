namespace Britt2022.A.E.O.Factories.ParameterElements.LengthsOfStay
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Classes.ParameterElements.LengthsOfStay;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.LengthsOfStay;

    internal sealed class ΦParameterElementFactory : IΦParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΦParameterElementFactory()
        {
        }

        public IΦParameterElement Create(
            IiIndexElement iIndexElement,
            IlIndexElement lIndexElement,
            IωIndexElement ωIndexElement,
            INullableValue<decimal> value)
        {
            IΦParameterElement parameterElement = null;

            try
            {
                parameterElement = new ΦParameterElement(
                    iIndexElement,
                    lIndexElement,
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