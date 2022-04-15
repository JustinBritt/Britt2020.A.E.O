namespace Britt2022.A.E.O.Factories.ParameterElements.StrategicTargets
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Classes.ParameterElements.StrategicTargets;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.StrategicTargets;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.StrategicTargets;

    internal sealed class LParameterElementFactory : ILParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LParameterElementFactory()
        {
        }

        public ILParameterElement Create(
            IiIndexElement iIndexElement,
            PositiveInt value)
        {
            ILParameterElement parameterElement = null;

            try
            {
                parameterElement = new LParameterElement(
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