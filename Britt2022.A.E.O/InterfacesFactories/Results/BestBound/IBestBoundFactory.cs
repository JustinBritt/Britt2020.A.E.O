namespace Britt2022.A.E.O.InterfacesFactories.Results.BestBound
{
    using Britt2022.A.E.O.Interfaces.Results.BestBound;

    public interface IBestBoundFactory
    {
        IBestBound Create(
            decimal value);
    }
}