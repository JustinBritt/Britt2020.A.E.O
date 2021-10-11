namespace Britt2020.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using Britt2020.A.E.O.Interfaces.CrossJoinElements;
    using Britt2020.A.E.O.Interfaces.IndexElements;

    internal sealed class ijCrossJoinElement : IijCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ijCrossJoinElement(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement)
        {
            this.iIndexElement = iIndexElement;

            this.jIndexElement = jIndexElement;
        }

        public IiIndexElement iIndexElement { get; }

        public IjIndexElement jIndexElement { get; }
    }
}