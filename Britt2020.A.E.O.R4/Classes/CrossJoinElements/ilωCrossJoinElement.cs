namespace Britt2020.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using Britt2020.A.E.O.Interfaces.CrossJoinElements;
    using Britt2020.A.E.O.Interfaces.IndexElements;

    internal sealed class ilωCrossJoinElement : IilωCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ilωCrossJoinElement(
            IiIndexElement iIndexElement,
            IlIndexElement lIndexElement,
            IωIndexElement ωIndexElement)
        {
            this.iIndexElement = iIndexElement;

            this.lIndexElement = lIndexElement;

            this.ωIndexElement = ωIndexElement;
        }

        public IiIndexElement iIndexElement { get; }

        public IlIndexElement lIndexElement { get; }

        public IωIndexElement ωIndexElement { get; }
    }
}