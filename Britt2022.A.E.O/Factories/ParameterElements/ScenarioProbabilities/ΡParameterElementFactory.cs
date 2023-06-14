namespace Britt2022.A.E.O.Factories.ParameterElements.ScenarioProbabilities
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Classes.ParameterElements.ScenarioProbabilities;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.ScenarioProbabilities;

    internal sealed class ΡParameterElementFactory : IΡParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΡParameterElementFactory()
        {
        }

        public IΡParameterElement Create(
            IωIndexElement ωIndexElement,
            INullableValue<decimal> value)
        {
            IΡParameterElement instance = null;

            try
            {
                instance = new ΡParameterElement(
                    ωIndexElement,
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