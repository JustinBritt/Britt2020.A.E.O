namespace Britt2020.A.E.O.Interfaces.Solutions
{
    using System.Threading.Tasks;

    using Britt2020.A.E.O.InterfacesAbstractFactories;
    using Britt2020.A.E.O.Interfaces.Configurations;
    using Britt2020.A.E.O.Interfaces.Contexts;
    using Britt2020.A.E.O.Interfaces.SolverConfigurations;

    public interface IWGPMSolution
    {
        Task<IWGPMOutputContext> Solve(
            IConstraintElementsAbstractFactory constraintElementsAbstractFactory,
            IConstraintsAbstractFactory constraintsAbstractFactory,
            IContextsAbstractFactory contextsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            ICrossJoinsAbstractFactory crossJoinsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IIndicesAbstractFactory indicesAbstractFactory,
            IModelsAbstractFactory modelsAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IParametersAbstractFactory parametersAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IWGPMConfiguration WGPMConfiguration,
            IWGPMInputContext WGPMInputContext,
            ISolverConfiguration solverConfiguration);
    }
}