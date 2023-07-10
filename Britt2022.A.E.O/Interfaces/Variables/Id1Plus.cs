namespace Britt2022.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.InterfacesFactories.Results.SurgeonScenarioDeviations;
    
    public interface Id1Plus
    {
        VariableCollection<IiIndexElement, IωIndexElement> Value { get; }

        int GetElementAt(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement);

        Interfaces.Results.SurgeonScenarioDeviations.Id1Plus GetElementsAt(
            IRedBlackTreeFactory redBlackTreeFactory,
            Id1PlusResultElementFactory d1PlusResultElementFactory,
            Id1PlusFactory d1PlusFactory,
            Ii i,
            Iω ω);
    }
}