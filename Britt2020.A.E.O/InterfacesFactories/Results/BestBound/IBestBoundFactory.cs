namespace Britt2020.A.E.O.InterfacesFactories.Results.BestBound
{
    using Britt2020.A.E.O.Interfaces.Results.BestBound;

    public interface IBestBoundFactory
    {
        IBestBound Create(
            decimal value);
    }
}