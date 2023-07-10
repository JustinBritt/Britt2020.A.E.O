namespace Britt2022.A.E.O.Factories.Results.SurgeonScenarioDeviations
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Classes.Results.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.InterfacesFactories.Results.SurgeonScenarioDeviations;

    internal sealed class d1PlusFactory : Id1PlusFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1PlusFactory()
        {
        }

        public Id1Plus Create(
            RedBlackTree<IiIndexElement, RedBlackTree<IωIndexElement, Id1PlusResultElement>> value)
        {
            Id1Plus instance = null;

            try
            {
                instance = new d1Plus(
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