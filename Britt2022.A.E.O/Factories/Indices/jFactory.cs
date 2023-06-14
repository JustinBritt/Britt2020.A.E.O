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

    internal sealed class jFactory : IjFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public jFactory()
        {
        }

        public Ij Create(
            ILocationComparer locationComparer,
            ImmutableList<IjIndexElement> value)
        {
            Ij instance = null;

            try
            {
                instance = new j(
                    this.CreateRedBlackTree(
                        locationComparer,
                        value));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }

        private RedBlackTree<Location, IjIndexElement> CreateRedBlackTree(
            ILocationComparer locationComparer,
            ImmutableList<IjIndexElement> value)
        {
            RedBlackTree<Location, IjIndexElement> redBlackTree = new RedBlackTree<Location, IjIndexElement>(
                locationComparer);

            foreach (IjIndexElement jIndexElement in value)
            {
                redBlackTree.Add(
                    jIndexElement.Value,
                    jIndexElement);
            }

            return redBlackTree;
        }
    }
}