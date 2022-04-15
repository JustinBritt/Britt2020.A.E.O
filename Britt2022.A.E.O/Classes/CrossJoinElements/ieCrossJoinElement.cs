namespace Britt2022.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using Britt2022.A.E.O.Interfaces.CrossJoinElements;
    using Britt2022.A.E.O.Interfaces.IndexElements;

    internal sealed class ieCrossJoinElement : IieCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ieCrossJoinElement(
            IiIndexElement iIndexElement,
            IeIndexElement eIndexElement)
        {
            this.iIndexElement = iIndexElement;

            this.eIndexElement = eIndexElement;
        }

        public IiIndexElement iIndexElement { get; }

        public IeIndexElement eIndexElement { get; }
    }
}