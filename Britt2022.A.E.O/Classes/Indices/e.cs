namespace Britt2022.A.E.O.Classes.Indices
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;

    internal sealed class e : Ie
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public e(
            RedBlackTree<INullableValue<int>, IeIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<INullableValue<int>, IeIndexElement> Value { get; }

        public IeIndexElement GetElementAt(
            INullableValue<int> value)
        {
            return this.Value[value];
        }
    }
}