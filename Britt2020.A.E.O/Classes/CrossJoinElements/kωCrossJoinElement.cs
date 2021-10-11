namespace Britt2020.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using Britt2020.A.E.O.Interfaces.CrossJoinElements;
    using Britt2020.A.E.O.Interfaces.IndexElements;

    internal sealed class kωCrossJoinElement : IkωCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public kωCrossJoinElement(
            IkIndexElement kIndexElement,
            IωIndexElement ωIndexElement)
        {
            this.kIndexElement = kIndexElement;

            this.ωIndexElement = ωIndexElement;
        }

        public IkIndexElement kIndexElement { get; }

        public IωIndexElement ωIndexElement { get; }
    }
}