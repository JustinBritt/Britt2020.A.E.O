namespace Britt2022.A.E.O.Factories.Results.SurgeonOperatingRoomDayScenarioDeviations
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Classes.Results.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayScenarioDeviations;

    internal sealed class d2MinusFactory : Id2MinusFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d2MinusFactory()
        {
        }

        public Id2Minus Create(
            RedBlackTree<IiIndexElement, RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, Id2MinusResultElement>>>> value)
        {
            Id2Minus instance = null;

            try
            {
                instance = new d2Minus(
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