namespace Britt2022.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.InterfacesFactories.Results.SurgeonScenarioDeviations;

    public interface Id1Plus
    {
        VariableCollection<IiIndexElement, IωIndexElement> Value { get; }

        int GetElementAt(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement);

        Interfaces.Results.SurgeonScenarioDeviations.Id1Plus GetElementsAt(
            Id1PlusResultElementFactory d1PlusResultElementFactory,
            Id1PlusFactory d1PlusFactory,
            Iiω iω);
    }
}