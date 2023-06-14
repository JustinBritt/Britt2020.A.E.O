namespace Britt2022.A.E.O.Factories.ParameterElements.SurgicalSpecialties
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2022.A.E.O.Classes.ParameterElements.SurgicalSpecialties;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties;

    internal sealed class SParameterElementFactory : ISParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SParameterElementFactory()
        {
        }

        public ISParameterElement Create(
            IrIndexElement rIndexElement,
            ImmutableList<IiIndexElement> value)
        {
            ISParameterElement instance = null;

            try
            {
                instance = new SParameterElement(
                    rIndexElement,
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