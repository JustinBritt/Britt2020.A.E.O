namespace Britt2020.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using Britt2020.A.E.O.Interfaces.CrossJoinElements;
    using Britt2020.A.E.O.Interfaces.IndexElements;

    internal sealed class ikCrossJoinElement : IikCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ikCrossJoinElement(
            IiIndexElement iIndexElement,
            IkIndexElement kIndexElement)
        {
            this.iIndexElement = iIndexElement;

            this.kIndexElement = kIndexElement;
        }

        public IiIndexElement iIndexElement { get; }

        public IkIndexElement kIndexElement { get; }
    }
}