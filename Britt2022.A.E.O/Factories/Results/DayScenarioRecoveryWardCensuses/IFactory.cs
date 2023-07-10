namespace Britt2022.A.E.O.Factories.Results.DayScenarioRecoveryWardCensuses
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Classes.Results.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.Interfaces.Results.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardCensuses;

    internal sealed class IFactory : IIFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IFactory()
        {
        }

        public II Create(
            RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, IIResultElement>> value)
        {
            II instance = null;

            try
            {
                instance = new I(
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