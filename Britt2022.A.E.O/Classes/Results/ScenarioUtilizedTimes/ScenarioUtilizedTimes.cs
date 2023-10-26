namespace Britt2022.A.E.O.Classes.Results.ScenarioUtilizedTimes
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class ScenarioUtilizedTimes : IScenarioUtilizedTimes
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUtilizedTimes(
            ImmutableList<IScenarioUtilizedTimesResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IScenarioUtilizedTimesResultElement> Value { get; }

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

            foreach (IScenarioUtilizedTimesResultElement scenarioUtilizedTimesResultElement in this.Value)
            {
                redBlackTree.Add(
                    scenarioUtilizedTimesResultElement.ωIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                        scenarioUtilizedTimesResultElement.Value));
            }

            return redBlackTree;
        }
    }
}