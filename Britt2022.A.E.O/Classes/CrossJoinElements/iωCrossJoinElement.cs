namespace Britt2022.A.E.O.Classes.CrossJoinElements
{
    using log4net;

    using Britt2022.A.E.O.Interfaces.CrossJoinElements;
    using Britt2022.A.E.O.Interfaces.IndexElements;

    internal sealed class iωCrossJoinElement : IiωCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public iωCrossJoinElement(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement)
        {
            this.iIndexElement = iIndexElement;

            this.ωIndexElement = ωIndexElement;
        }

        public IiIndexElement iIndexElement { get; }

        public IωIndexElement ωIndexElement { get; }
    }
}