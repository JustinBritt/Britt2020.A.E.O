namespace Britt2022.A.E.O.Classes.Results.SurgeonScenarioNumberPatients
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    
    internal sealed class SurgeonScenarioNumberPatients : ISurgeonScenarioNumberPatients
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioNumberPatients(
            ImmutableList<ISurgeonScenarioNumberPatientsResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISurgeonScenarioNumberPatientsResultElement> Value { get; }

        private int GetElementAtAsint(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement)
        {
            return this.Value
                .Where(x => x.iIndexElement == iIndexElement && x.ωIndexElement == ωIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Ii i,
            Iω ω)
        {
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> outerRedBlackTree = new(
                new Britt2022.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (IiIndexElement iIndexElement in i.Value.Values)
            {
                RedBlackTree<INullableValue<int>, INullableValue<int>> innerRedBlackTree = new(
                    new Britt2022.A.E.O.Classes.Comparers.NullableValueintComparer());

                foreach (IωIndexElement ωIndexElement in ω.Value.Values)
                {
                    innerRedBlackTree.Add(
                        ωIndexElement.Value,
                        nullableValueFactory.Create<int>(
                            this.GetElementAtAsint(
                                iIndexElement,
                                ωIndexElement)));
                }

                outerRedBlackTree.Add(
                    iIndexElement.Value,
                    innerRedBlackTree);
            }

            return outerRedBlackTree;
        }
    }
}