namespace Britt2022.A.E.O.InterfacesAbstractFactories
{
    public interface IAbstractFactory
    {
        IConfigurationsAbstractFactory CreateConfigurationsAbstractFactory();

        IConstraintElementsAbstractFactory CreateConstraintElementsAbstractFactory();

        IConstraintsAbstractFactory CreateConstraintsAbstractFactory();

        IContextsAbstractFactory CreateContextsAbstractFactory();

        ICrossJoinElementsAbstractFactory CreateCrossJoinElementsAbstractFactory();

        ICrossJoinsAbstractFactory CreateCrossJoinsAbstractFactory();

        IDependenciesAbstractFactory CreateDependenciesAbstractFactory();

        IIndexElementsAbstractFactory CreateIndexElementsAbstractFactory();

        IIndicesAbstractFactory CreateIndicesAbstractFactory();

        IModelsAbstractFactory CreateModelsAbstractFactory();

        IObjectiveFunctionsAbstractFactory CreateObjectiveFunctionsAbstractFactory();

        IParameterElementsAbstractFactory CreateParameterElementsAbstractFactory();

        IParametersAbstractFactory CreateParametersAbstractFactory();

        IResultElementsAbstractFactory CreateResultElementsAbstractFactory();

        IResultsAbstractFactory CreateResultsAbstractFactory();

        ISolutionsAbstractFactory CreateSolutionsAbstractFactory();

        ISolverConfigurationsAbstractFactory CreateSolverConfigurationsAbstractFactory();

        IVariablesAbstractFactory CreateVariablesAbstractFactory();
    }
}