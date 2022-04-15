namespace Britt2022.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using Britt2022.A.E.O.Interfaces.CrossJoinElements;
    using Britt2022.A.E.O.Interfaces.IndexElements;

    internal sealed class ieωCrossJoinElement : IieωCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ieωCrossJoinElement(
            IiIndexElement iIndexElement,
            IeIndexElement eIndexElement,
            IωIndexElement ωIndexElement)
        {
            this.iIndexElement = iIndexElement;

            this.eIndexElement = eIndexElement;

            this.ωIndexElement = ωIndexElement;
        }

        public IiIndexElement iIndexElement { get; }

        public IeIndexElement eIndexElement { get; }

        public IωIndexElement ωIndexElement { get; }
    }
}