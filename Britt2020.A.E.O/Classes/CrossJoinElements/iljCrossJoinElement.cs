namespace Britt2020.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using Britt2020.A.E.O.Interfaces.CrossJoinElements;
    using Britt2020.A.E.O.Interfaces.IndexElements;

    internal sealed class iljCrossJoinElement : IiljCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public iljCrossJoinElement(
            IiIndexElement iIndexElement,
            IlIndexElement lIndexElement,
            IjIndexElement jIndexElement)
        {
            this.iIndexElement = iIndexElement;

            this.lIndexElement = lIndexElement;

            this.jIndexElement = jIndexElement;
        }

        public IiIndexElement iIndexElement { get; }

        public IlIndexElement lIndexElement { get; }

        public IjIndexElement jIndexElement { get; }
    }
}