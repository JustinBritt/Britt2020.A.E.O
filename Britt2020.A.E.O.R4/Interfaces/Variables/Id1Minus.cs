namespace Britt2020.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using Britt2020.A.E.O.Interfaces.CrossJoins;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioDeviations;
    using Britt2020.A.E.O.InterfacesFactories.Results.SurgeonScenarioDeviations;

    public interface Id1Minus
    {
        VariableCollection<IiIndexElement, IωIndexElement> Value { get; }

        int GetElementAt(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement);

        Interfaces.Results.SurgeonScenarioDeviations.Id1Minus GetElementsAt(
            Id1MinusResultElementFactory d1MinusResultElementFactory,
            Id1MinusFactory d1MinusFactory,
            Iiω iω);
    }
}