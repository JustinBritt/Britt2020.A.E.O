﻿namespace Britt2020.A.E.O.InterfacesAbstractFactories
{
    using Britt2020.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Britt2020.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;
    using Britt2020.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization.Configuration;

    public interface IDependenciesAbstractFactory
    {
        IConfigurationFactory CreateConfigurationFactory();

        IModelFactory CreateModelFactory();

        IModelScopeFactory CreateModelScopeFactory();

        INullableValueFactory CreateNullableValueFactory();

        IObjectiveFactory CreateObjectiveFactory();

        ISolverFactory CreateSolverFactory();

        ISolverConfigurationFactory CreateSolverConfigurationFactory();

        IVariableFactory CreateVariableFactory();

        IVariableCollectionFactory CreateVariableCollectionFactory();
    }
}