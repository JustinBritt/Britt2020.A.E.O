namespace Britt2022.A.E.O.Classes.Indices
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;

    internal sealed class i : Ii
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public i(
            RedBlackTree<Organization, IiIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<Organization, IiIndexElement> Value { get; }

        public IiIndexElement GetElementAt(
            Organization value)
        {
            return this.Value[value];
        }
    }
}