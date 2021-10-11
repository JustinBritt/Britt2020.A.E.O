namespace Britt2020.A.E.O.InterfacesFactories.Results.NumberOfExploredNodes
{
    using Britt2020.A.E.O.Interfaces.Results.NumberOfExploredNodes;

    public interface INumberOfExploredNodesFactory
    {
        INumberOfExploredNodes Create(
            long value);
    }
}