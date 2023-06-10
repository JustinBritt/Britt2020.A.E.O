namespace Britt2022.A.E.O.Factories.ParameterElements.PreferencesOfSurgeons
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Classes.ParameterElements.PreferencesOfSurgeons;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.PreferencesOfSurgeons;

    internal sealed class ΠParameterElementFactory : IΠParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΠParameterElementFactory()
        {
        }

        public IΠParameterElement Create(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            INullableValue<bool> value)
        {
            IΠParameterElement parameterElement = null;

            try
            {
                parameterElement = new ΠParameterElement(
                    iIndexElement,
                    jIndexElement,
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