namespace Britt2020.A.E.O.InterfacesFactories.Results.ObjectiveValue
{
    using Britt2020.A.E.O.Interfaces.Results.ObjectiveValue;

    public interface IObjectiveValueFactory
    {
        IObjectiveValue Create(
            decimal value);
    }
}