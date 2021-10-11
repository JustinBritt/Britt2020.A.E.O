namespace Britt2020.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using Britt2020.A.E.O.Interfaces.CrossJoinElements;
    using Britt2020.A.E.O.Interfaces.IndexElements;

    internal sealed class jkCrossJoinElement : IjkCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public jkCrossJoinElement(
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement)
        {
            this.jIndexElement = jIndexElement;

            this.kIndexElement = kIndexElement;
        }

        public IjIndexElement jIndexElement { get; }

        public IkIndexElement kIndexElement { get; }
    }
}