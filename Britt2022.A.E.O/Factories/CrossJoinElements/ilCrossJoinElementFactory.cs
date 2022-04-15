namespace Britt2022.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.CrossJoinElements;
    using Britt2022.A.E.O.Interfaces.CrossJoinElements;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class ilCrossJoinElementFactory : IilCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ilCrossJoinElementFactory()
        {
        }

        public IilCrossJoinElement Create(
            IiIndexElement iIndexElement,
            IlIndexElement lIndexElement)
        {
            IilCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new ilCrossJoinElement(
                    iIndexElement,
                    lIndexElement);
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