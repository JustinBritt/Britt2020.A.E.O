namespace Britt2020.A.E.O.Factories.ParameterElements.PreferencesOfSurgeons
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Classes.ParameterElements.PreferencesOfSurgeons;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons;
    using Britt2020.A.E.O.InterfacesFactories.ParameterElements.PreferencesOfSurgeons;

    internal sealed class ΩParameterElementFactory : IΩParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΩParameterElementFactory()
        {
        }

        public IΩParameterElement Create(
            IiIndexElement iIndexElement,
            IkIndexElement kIndexElement,
            FhirBoolean value)
        {
            IΩParameterElement parameterElement = null;

            try
            {
                parameterElement = new ΩParameterElement(
                    iIndexElement,
                    kIndexElement,
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