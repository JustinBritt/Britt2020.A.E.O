namespace Britt2022.A.E.O.Visitors.Results.ScenarioRecoveryWardCensuses
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.Comparers;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Britt2022.A.E.O.InterfacesVisitors.Results.ScenarioRecoveryWardCensuses;

    internal sealed class IMinVisitor<TKey, TValue> : IIMinVisitor<TKey, TValue>
        where TKey : IωIndexElement
        where TValue : IIMinResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IMinVisitor(
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            INullableValueintComparer nullableValueintComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.RedBlackTree = redBlackTreeFactory.Create<INullableValue<int>, INullableValue<decimal>>(
                nullableValueintComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        public bool HasCompleted => false;

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            this.RedBlackTree.Add(
                obj.Key.Value,
                this.NullableValueFactory.Create<decimal>(
                    obj.Value.Value));
        }
    }
}