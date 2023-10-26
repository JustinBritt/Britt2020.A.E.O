namespace Britt2022.A.E.O.Classes.Results.ScenarioTotalTimes
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class ScenarioTotalTimes : IScenarioTotalTimes
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioTotalTimes(
            ImmutableList<IScenarioTotalTimesResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IScenarioTotalTimesResultElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IωIndexElement ωIndexElement)
        {
            return this.Value
                .Where(x => x.ωIndexElement == ωIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<INullableValue<int>, INullableValue<decimal>> redBlackTree = new(
                new Britt2022.A.E.O.Classes.Comparers.NullableValueintComparer());

            foreach (IScenarioTotalTimesResultElement scenarioTotalTimesResultElement in this.Value)
            {
                redBlackTree.Add(
                    scenarioTotalTimesResultElement.ωIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                        scenarioTotalTimesResultElement.Value));
            }

            return redBlackTree;
        }
    }
}