namespace Britt2020.A.E.O.InterfacesFactories.Variables
{
    using OPTANO.Modeling.Optimization;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Variables;

    public interface IIMaxFactory
    {
        IIMax Create(
            VariableCollection<IωIndexElement> value);
    }
}