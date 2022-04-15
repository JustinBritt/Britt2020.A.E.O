namespace Britt2022.A.E.O.InterfacesFactories.Variables
{
    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Variables;

    public interface Id1MinusFactory
    {
        Id1Minus Create(
            VariableCollection<IiIndexElement, IωIndexElement> value);
    }
}