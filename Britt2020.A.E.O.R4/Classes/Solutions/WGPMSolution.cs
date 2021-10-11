namespace Britt2020.A.E.O.Classes.Solutions
{
    using System.Threading.Tasks;

    using log4net;

    using OPTANO.Modeling.Common;
    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Interfaces;

    using Britt2020.A.E.O.InterfacesAbstractFactories;
    using Britt2020.A.E.O.Interfaces.Configurations;
    using Britt2020.A.E.O.Interfaces.Contexts;
    using Britt2020.A.E.O.Interfaces.Models;
    using Britt2020.A.E.O.Interfaces.Solutions;
    using Britt2020.A.E.O.Interfaces.SolverConfigurations;

    internal sealed class WGPMSolution : IWGPMSolution
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WGPMSolution()
        {
        }

        public Task<IWGPMOutputContext> Solve(
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
            ISolverConfiguration solverConfiguration)
        {
            IWGPMOutputContext WGPMOutputContext = null;

            return Task.Run(() => 
            {
                using (ModelScope modelScope = dependenciesAbstractFactory.CreateModelScopeFactory().Create(WGPMConfiguration.Value))
                {
                    IWGPMModel model = modelsAbstractFactory.CreateWGPMModelFactory().Create(
                        constraintElementsAbstractFactory,
                        constraintsAbstractFactory,
                        crossJoinElementsAbstractFactory,
                        crossJoinsAbstractFactory,
                        dependenciesAbstractFactory,
                        indexElementsAbstractFactory,
                        indicesAbstractFactory,
                        objectiveFunctionsAbstractFactory,
                        parameterElementsAbstractFactory,
                        parametersAbstractFactory,
                        variablesAbstractFactory,
                        WGPMInputContext);

                    using (ISolver solver = dependenciesAbstractFactory.CreateSolverFactory().Create(solverConfiguration))
                    {
                        Solution solution = solver?.Solve(
                            model?.Model);

                        if (solution?.ModelStatus == OPTANO.Modeling.Optimization.Solver.ModelStatus.Feasible)
                        {
                            model.Model.VariableCollections.ForEach(vc => vc.SetVariableValues(solution.VariableValues));

                            WGPMOutputContext = contextsAbstractFactory.CreateWGPMOutputContextFactory().Create(
                                dependenciesAbstractFactory,
                                resultElementsAbstractFactory,
                                resultsAbstractFactory,
                                model,
                                solution);
                        }
                    }
                }

                return WGPMOutputContext;
            });
        }
    }
}