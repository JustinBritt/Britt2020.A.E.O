namespace Britt2022.A.E.O.Factories.Results.ScenarioRecoveryWardCensuses
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Classes.Results.ScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardCensuses;
   
    internal sealed class IMaxFactory : IIMaxFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IMaxFactory()
        {
        }

        public IIMax Create(
            RedBlackTree<IωIndexElement, IIMaxResultElement> value)
        {
            IIMax instance = null;

            try
            {
                instance = new IMax(
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