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

    internal sealed class eFactory : IeFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public eFactory()
        {
        }

        public Ie Create(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IeIndexElement> value)
        {
            Ie instance = null;

            try
            {
                instance = new e(
                    this.CreateRedBlackTree(
                        nullableValueintComparer,
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

        private RedBlackTree<INullableValue<int>, IeIndexElement> CreateRedBlackTree(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IeIndexElement> value)
        {
            RedBlackTree<INullableValue<int>, IeIndexElement> redBlackTree = new RedBlackTree<INullableValue<int>, IeIndexElement>(
                nullableValueintComparer);

            foreach (IeIndexElement eIndexElement in value)
            {
                redBlackTree.Add(
                    eIndexElement.Value,
                    eIndexElement);
            }

            return redBlackTree;
        }
    }
}