namespace Britt2022.A.E.O.Interfaces.Results.NumberOfExploredNodes
{
    public interface INumberOfExploredNodes
    {
        long Value { get; }

        long GetValueForOutputContext();
    }
}