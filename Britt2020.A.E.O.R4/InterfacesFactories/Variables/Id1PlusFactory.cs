namespace Britt2020.A.E.O.InterfacesFactories.Variables
{
    using OPTANO.Modeling.Optimization;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Variables;

    public interface Id1PlusFactory
    {
        Id1Plus Create(
            VariableCollection<IiIndexElement, IωIndexElement> value);
    }
}