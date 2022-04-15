namespace Britt2022.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using Britt2022.A.E.O.Interfaces.CrossJoinElements;
    using Britt2022.A.E.O.Interfaces.IndexElements;

    internal sealed class ijkCrossJoinElement : IijkCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ijkCrossJoinElement(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement)
        {
            this.iIndexElement = iIndexElement;

            this.jIndexElement = jIndexElement;

            this.kIndexElement = kIndexElement;
        }

        public IiIndexElement iIndexElement { get; }

        public IjIndexElement jIndexElement { get; }

        public IkIndexElement kIndexElement { get; }
    }
}