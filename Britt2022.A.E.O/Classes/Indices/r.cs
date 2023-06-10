namespace Britt2022.A.E.O.Classes.Indices
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;

    internal sealed class r : Ir
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public r(
            RedBlackTree<Organization, IrIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<Organization, IrIndexElement> Value { get; }

        public IrIndexElement GetElementAt(
            Organization value)
        {
            return this.Value[value];
        }
    }
}