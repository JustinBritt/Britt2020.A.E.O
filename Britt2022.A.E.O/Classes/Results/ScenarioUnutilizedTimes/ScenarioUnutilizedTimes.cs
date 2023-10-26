namespace Britt2022.A.E.O.Classes.Results.ScenarioUnutilizedTimes
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class ScenarioUnutilizedTimes : IScenarioUnutilizedTimes
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnutilizedTimes(
            ImmutableList<IScenarioUnutilizedTimesResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IScenarioUnutilizedTimesResultElement> Value { get; }

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

            foreach (IScenarioUnutilizedTimesResultElement scenarioUnutilizedTimesResultElement in this.Value)
            {
                redBlackTree.Add(
                    scenarioUnutilizedTimesResultElement.ωIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                        scenarioUnutilizedTimesResultElement.Value));
            }

            return redBlackTree;
        }
    }
}