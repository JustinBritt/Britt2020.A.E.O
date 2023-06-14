namespace Britt2022.A.E.O.Factories.Parameters.StrategicTargets
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Classes.Parameters.StrategicTargets;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.StrategicTargets;
    using Britt2022.A.E.O.Interfaces.ParameterElements.StrategicTargets;
    using Britt2022.A.E.O.InterfacesFactories.Parameters.StrategicTargets;

    internal sealed class LFactory : ILFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LFactory()
        {
        }

        public IL Create(
            RedBlackTree<IiIndexElement, ILParameterElement> value)
        {
            IL parameter = null;

            try
            {
                parameter = new L(
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