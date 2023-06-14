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

    internal sealed class ωFactory : IωFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ωFactory()
        {
        }

        public Iω Create(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IωIndexElement> value)
        {
            Iω instance = null;

            try
            {
                instance = new ω(
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

        private RedBlackTree<INullableValue<int>, IωIndexElement> CreateRedBlackTree(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IωIndexElement> value)
        {
            RedBlackTree<INullableValue<int>, IωIndexElement> redBlackTree = new RedBlackTree<INullableValue<int>, IωIndexElement>(
                nullableValueintComparer);

            foreach (IωIndexElement ωIndexElement in value)
            {
                redBlackTree.Add(
                    ωIndexElement.Value,
                    ωIndexElement);
            }

            return redBlackTree;
        }
    }
}