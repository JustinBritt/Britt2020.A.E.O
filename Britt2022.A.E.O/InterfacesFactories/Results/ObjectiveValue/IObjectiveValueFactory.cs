namespace Britt2022.A.E.O.InterfacesFactories.Results.ObjectiveValue
{
    using Britt2022.A.E.O.Interfaces.Results.ObjectiveValue;

    public interface IObjectiveValueFactory
    {
        IObjectiveValue Create(
            decimal value);
    }
}