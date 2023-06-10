namespace Britt2022.A.E.O.InterfacesFactories.Models
{
    using Britt2022.A.E.O.InterfacesAbstractFactories;
    using Britt2022.A.E.O.Interfaces.Contexts;
    using Britt2022.A.E.O.Interfaces.Models;

    public interface IWGPMModelFactory
    {
        IWGPMModel Create(
            IComparersAbstractFactory comparersAbstractFactory,
            IConstraintElementsAbstractFactory constraintElementsAbstractFactory,
            IConstraintsAbstractFactory constraintsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            ICrossJoinsAbstractFactory crossJoinsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IIndicesAbstractFactory indicesAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IParametersAbstractFactory parametersAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IWGPMInputContext context);
    }
}