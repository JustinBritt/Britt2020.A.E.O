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

    internal sealed class iFactory : IiFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public iFactory()
        {
        }

        public Ii Create(
            IOrganizationComparer organizationComparer,
            ImmutableList<IiIndexElement> value)
        {
            Ii index = null;

            try
            {
                index = new i(
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

        private RedBlackTree<Organization, IiIndexElement> CreateRedBlackTree(
            IOrganizationComparer organizationComparer,
            ImmutableList<IiIndexElement> value)
        {
            RedBlackTree<Organization, IiIndexElement> redBlackTree = new RedBlackTree<Organization, IiIndexElement>(
                organizationComparer);

            foreach (IiIndexElement iIndexElement in value)
            {
                redBlackTree.Add(
                    iIndexElement.Value,
                    iIndexElement);
            }

            return redBlackTree;
        }
    }
}