namespace Britt2022.A.E.O.Factories.Parameters.SurgicalSpecialties
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Classes.Parameters.SurgicalSpecialties;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using Britt2022.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using Britt2022.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialties;

    internal sealed class SFactory : ISFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SFactory()
        {
        }

        public IS Create(
            RedBlackTree<IrIndexElement, ImmutableList<IiIndexElement>> redBlackTree,
            ImmutableList<ISParameterElement> value)
        {
            IS parameter = null;

            try
            {
                parameter = new S(
                    redBlackTree,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}