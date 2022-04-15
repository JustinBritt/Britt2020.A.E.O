namespace Britt2022.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using Britt2022.A.E.O.Interfaces.CrossJoinElements;
    using Britt2022.A.E.O.Interfaces.IndexElements;

    internal sealed class ilCrossJoinElement : IilCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ilCrossJoinElement(
            IiIndexElement iIndexElement,
            IlIndexElement lIndexElement)
        {
            this.iIndexElement = iIndexElement;

            this.lIndexElement = lIndexElement;
        }

        public IiIndexElement iIndexElement { get; }

        public IlIndexElement lIndexElement { get; }
    }
}