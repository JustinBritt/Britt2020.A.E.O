namespace Britt2022.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using Britt2022.A.E.O.Interfaces.CrossJoinElements;
    using Britt2022.A.E.O.Interfaces.IndexElements;

    internal sealed class ijkωCrossJoinElement : IijkωCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ijkωCrossJoinElement(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement,
            IωIndexElement ωIndexElement)
        {
            this.iIndexElement = iIndexElement;

            this.jIndexElement = jIndexElement;

            this.kIndexElement = kIndexElement;

            this.ωIndexElement = ωIndexElement;
        }

        public IiIndexElement iIndexElement { get; }

        public IjIndexElement jIndexElement { get; }

        public IkIndexElement kIndexElement { get; }

        public IωIndexElement ωIndexElement { get; }
    }
}