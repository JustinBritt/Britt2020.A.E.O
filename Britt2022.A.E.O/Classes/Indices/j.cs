namespace Britt2022.A.E.O.Classes.Indices
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;

    internal sealed class j : Ij
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public j(
            RedBlackTree<Location, IjIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<Location, IjIndexElement> Value { get; }

        public IjIndexElement GetElementAt(
            Location value)
        {
            return this.Value[value];
        }
    }
}