namespace Britt2020.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using Britt2020.A.E.O.Classes.CrossJoinElements;
    using Britt2020.A.E.O.Interfaces.CrossJoinElements;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class ijCrossJoinElementFactory : IijCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ijCrossJoinElementFactory()
        {
        }

        public IijCrossJoinElement Create(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement)
        {
            IijCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new ijCrossJoinElement(
                    iIndexElement,
                    jIndexElement);
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