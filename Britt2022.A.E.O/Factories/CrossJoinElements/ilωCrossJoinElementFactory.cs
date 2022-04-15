namespace Britt2022.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.CrossJoinElements;
    using Britt2022.A.E.O.Interfaces.CrossJoinElements;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class ilωCrossJoinElementFactory : IilωCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ilωCrossJoinElementFactory()
        {
        }

        public IilωCrossJoinElement Create(
            IiIndexElement iIndexElement,
            IlIndexElement lIndexElement,
            IωIndexElement ωIndexElement)
        {
            IilωCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new ilωCrossJoinElement(
                    iIndexElement,
                    lIndexElement,
                    ωIndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return crossJoinElement;
        }
    }
}