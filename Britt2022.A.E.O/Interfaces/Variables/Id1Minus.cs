namespace Britt2022.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.InterfacesFactories.Results.SurgeonScenarioDeviations;
    
    public interface Id1Minus
    {
        VariableCollection<IiIndexElement, IωIndexElement> Value { get; }

        int GetElementAt(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement);

        Interfaces.Results.SurgeonScenarioDeviations.Id1Minus GetElementsAt(
            IRedBlackTreeFactory redBlackTreeFactory,
            Id1MinusResultElementFactory d1MinusResultElementFactory,
            Id1MinusFactory d1MinusFactory,
            Ii i,
            Iω ω);
    }
}