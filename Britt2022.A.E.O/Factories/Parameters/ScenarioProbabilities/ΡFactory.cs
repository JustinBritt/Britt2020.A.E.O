namespace Britt2022.A.E.O.Factories.Parameters.ScenarioProbabilities
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Classes.Parameters.ScenarioProbabilities;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;
    using Britt2022.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using Britt2022.A.E.O.InterfacesFactories.Parameters.ScenarioProbabilities;

    internal sealed class ΡFactory : IΡFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΡFactory()
        {
        }

        public IΡ Create(
            RedBlackTree<IωIndexElement, IΡParameterElement> value)
        {
            IΡ instance = null;

            try
            {
                instance = new Ρ(
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