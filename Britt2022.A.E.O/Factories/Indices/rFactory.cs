namespace Britt2022.A.E.O.Factories.Indices
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Classes.Indices;
    using Britt2022.A.E.O.Interfaces.Comparers;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.InterfacesFactories.Indices;

    internal sealed class rFactory : IrFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rFactory()
        {
        }

        public Ir Create(
            IOrganizationComparer organizationComparer,
            ImmutableList<IrIndexElement> value)
        {
            Ir index = null;

            try
            {
                index = new r(
                    this.CreateRedBlackTree(
                        organizationComparer,
                        value));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return index;
        }

        private RedBlackTree<Organization, IrIndexElement> CreateRedBlackTree(
            IOrganizationComparer organizationComparer,
            ImmutableList<IrIndexElement> value)
        {
            RedBlackTree<Organization, IrIndexElement> redBlackTree = new RedBlackTree<Organization, IrIndexElement>(
                organizationComparer);

            foreach (IrIndexElement rIndexElement in value)
            {
                redBlackTree.Add(
                    rIndexElement.Value,
                    rIndexElement);
            }

            return redBlackTree;
        }
    }
}