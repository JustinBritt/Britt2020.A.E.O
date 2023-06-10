namespace Britt2022.A.E.O.Factories.ParameterElements.LengthsOfStay
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Classes.ParameterElements.LengthsOfStay;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.LengthsOfStay;

    internal sealed class hParameterElementFactory : IhParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public hParameterElementFactory()
        {
        }

        public IhParameterElement Create(
            IiIndexElement iIndexElement,
            INullableValue<int> value)
        {
            IhParameterElement parameterElement = null;

            try
            {
                parameterElement = new hParameterElement(
                    iIndexElement,
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