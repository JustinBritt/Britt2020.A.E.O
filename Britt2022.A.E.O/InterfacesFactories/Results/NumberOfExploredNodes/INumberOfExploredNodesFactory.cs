namespace Britt2022.A.E.O.InterfacesFactories.Results.NumberOfExploredNodes
{
    using Britt2022.A.E.O.Interfaces.Results.NumberOfExploredNodes;

    public interface INumberOfExploredNodesFactory
    {
        INumberOfExploredNodes Create(
            long value);
    }
}