namespace Britt2020.A.E.O.InterfacesFactories.Variables
{
    using OPTANO.Modeling.Optimization;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Variables;

    public interface Id2MinusFactory
    {
        Id2Minus Create(
            VariableCollection<IiIndexElement, IjIndexElement, IkIndexElement, IωIndexElement> value);
    }
}