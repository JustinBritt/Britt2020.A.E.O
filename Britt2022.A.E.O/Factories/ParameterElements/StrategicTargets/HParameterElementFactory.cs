namespace Britt2022.A.E.O.Factories.ParameterElements.StrategicTargets
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Classes.ParameterElements.StrategicTargets;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.StrategicTargets;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.StrategicTargets;

    internal sealed class HParameterElementFactory : IHParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HParameterElementFactory()
        {
        }

        public IHParameterElement Create(
            IiIndexElement iIndexElement,
            INullableValue<int> value)
        {
            IHParameterElement instance = null;

            try
            {
                instance = new HParameterElement(
                    iIndexElement,
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