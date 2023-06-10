namespace Britt2022.A.E.O.Classes.Models
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using Britt2022.A.E.O.InterfacesAbstractFactories;
    using Britt2022.A.E.O.Interfaces.Contexts;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;

    using Britt2022.A.E.O.Interfaces.Parameters.GoalWeights;
    using Britt2022.A.E.O.Interfaces.Parameters.LengthsOfStay;
    using Britt2022.A.E.O.Interfaces.Parameters.PreferencesOfSurgeons;
    using Britt2022.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using Britt2022.A.E.O.Interfaces.Parameters.StrategicTargets;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2022.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using Britt2022.A.E.O.Interfaces.Models;
    using Britt2022.A.E.O.Interfaces.Variables;

    internal sealed class WGPMModel : IWGPMModel
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WGPMModel(
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
            IWGPMInputContext context)
        {
            this.Context = context;

            this.Model = dependenciesAbstractFactory.CreateModelFactory().Create();

            // Indices

            // e
            this.e = indicesAbstractFactory.CreateeFactory().Create(
                comparersAbstractFactory.CreateNullableValueintComparerFactory().Create(),
                this.Context.Clusters
                .Select(x => indexElementsAbstractFactory.CreateeIndexElementFactory().Create(x))
                .ToImmutableList());

            // i
            this.i = indicesAbstractFactory.CreateiFactory().Create(
                comparersAbstractFactory.CreateOrganizationComparerFactory().Create(),
                this.Context.Surgeons
                .Entry
                .Where(x => x.Resource is Organization)
                .Select(x => indexElementsAbstractFactory.CreateiIndexElementFactory().Create((Organization)x.Resource))
                .ToImmutableList());

            // j
            this.j = indicesAbstractFactory.CreatejFactory().Create(
                comparersAbstractFactory.CreateLocationComparerFactory().Create(),
                this.Context.OperatingRooms
                .Entry
                .Where(x => x.Resource is Location)
                .Select(x => indexElementsAbstractFactory.CreatejIndexElementFactory().Create((Location)x.Resource))
                .ToImmutableList());

            // k
            this.k = indicesAbstractFactory.CreatekFactory().Create(
                this.Context.PlanningHorizon
                .Select(x => indexElementsAbstractFactory.CreatekIndexElementFactory().Create(
                    x.Key.Value.Value,
                    x.Value))
                .ToImmutableList());

            // l
            this.l = indicesAbstractFactory.CreatelFactory().Create(
                this.Context.LengthOfStayDays
                .Select(x => indexElementsAbstractFactory.CreatelIndexElementFactory().Create(x))
                .ToImmutableList());

            // r
            this.r = indicesAbstractFactory.CreaterFactory().Create(
                comparersAbstractFactory.CreateOrganizationComparerFactory().Create(),
                this.Context.SurgicalSpecialties
                .Select(x => x.Item1)
                .Select(x => indexElementsAbstractFactory.CreaterIndexElementFactory().Create(x))
                .ToImmutableList());

            // ω
            this.ω = indicesAbstractFactory.CreateωFactory().Create(
                comparersAbstractFactory.CreateNullableValueintComparerFactory().Create(),
                this.Context.Scenarios
                .Select(x => indexElementsAbstractFactory.CreateωIndexElementFactory().Create(x))
                .ToImmutableList());

            // Cross joins

            // ieω
            this.ieω = crossJoinsAbstractFactory.CreateieωFactory().Create(
                this.i.Value.Values
                .SelectMany(b => this.e.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreateieCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.ω.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreateieωCrossJoinElementFactory().Create(a.iIndexElement, a.eIndexElement, b))
                .ToImmutableList());

            // ij
            this.ij = crossJoinsAbstractFactory.CreateijFactory().Create(
                this.i.Value.Values
                .SelectMany(b => this.j.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreateijCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // ijk
            this.ijk = crossJoinsAbstractFactory.CreateijkFactory().Create(
                this.i.Value.Values
                .SelectMany(b => this.j.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreateijCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.k.Value, (a, b) => crossJoinElementsAbstractFactory.CreateijkCrossJoinElementFactory().Create(a.iIndexElement, a.jIndexElement, b))
                .ToImmutableList());

            // ijkω
            this.ijkω = crossJoinsAbstractFactory.CreateijkωFactory().Create(
                this.i.Value.Values
                .SelectMany(b => this.j.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreateijCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.k.Value, (a, b) => crossJoinElementsAbstractFactory.CreateijkCrossJoinElementFactory().Create(a.iIndexElement, a.jIndexElement, b))
                .SelectMany(b => this.ω.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreateijkωCrossJoinElementFactory().Create(a.iIndexElement, a.jIndexElement, a.kIndexElement, b))
                .ToImmutableList());

            // ik
            this.ik = crossJoinsAbstractFactory.CreateikFactory().Create(
                this.i.Value.Values
                .SelectMany(b => this.k.Value, (a, b) => crossJoinElementsAbstractFactory.CreateikCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // ilj
            this.ilj = crossJoinsAbstractFactory.CreateiljFactory().Create(
                this.i.Value.Values
                .SelectMany(b => this.l.Value, (a, b) => crossJoinElementsAbstractFactory.CreateilCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.j.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreateiljCrossJoinElementFactory().Create(a.iIndexElement, a.lIndexElement, b))
                .ToImmutableList());

            // ilω
            this.ilω = crossJoinsAbstractFactory.CreateilωFactory().Create(
                this.i.Value.Values
                .SelectMany(b => this.l.Value, (a, b) => crossJoinElementsAbstractFactory.CreateilCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.ω.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreateilωCrossJoinElementFactory().Create(a.iIndexElement, a.lIndexElement, b))
                .ToImmutableList());

            // iω
            this.iω = crossJoinsAbstractFactory.CreateiωFactory().Create(
                this.i.Value.Values
                .SelectMany(b => this.ω.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreateiωCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // jk
            this.jk = crossJoinsAbstractFactory.CreatejkFactory().Create(
                this.j.Value.Values
                .SelectMany(b => this.k.Value, (a, b) => crossJoinElementsAbstractFactory.CreatejkCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // kω
            this.kω = crossJoinsAbstractFactory.CreatekωFactory().Create(
                this.k.Value
                .SelectMany(b => this.ω.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatekωCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // Parameters

            // A(i, ω) calculated externally
            if (this.Context != null && this.Context.SurgeonScenarioWeightedAverageSurgicalDurations != null)
            {
                this.A = parametersAbstractFactory.CreateAFactory().Create(
                    this.Context.SurgeonScenarioWeightedAverageSurgicalDurations
                    .Select(x => parameterElementsAbstractFactory.CreateAParameterElementFactory().Create(
                        this.i.GetElementAt(x.Item1),
                        this.ω.GetElementAt(x.Item2),
                        x.Item3))
                    .ToImmutableList());
            }

            // B(r)
            this.B = parametersAbstractFactory.CreateBFactory().Create(
                this.Context.SurgicalSpecialtyStrategicTargetNumberTimeBlocks
                .Select(x => parameterElementsAbstractFactory.CreateBParameterElementFactory().Create(
                    this.r.GetElementAt(x.Key),
                    x.Value))
                .ToImmutableList());

            // H(i)
            this.H = parametersAbstractFactory.CreateHFactory().Create(
                this.Context.SurgeonMaximumNumberTimeBlocks
                .Select(x => parameterElementsAbstractFactory.CreateHParameterElementFactory().Create(
                    this.i.GetElementAt(x.Key),
                    x.Value))
                .ToImmutableList());

            // h(i)
            this.h = parametersAbstractFactory.CreatehFactory().Create(
                this.Context.SurgeonMaximumLengthsOfStay
                .Select(x => parameterElementsAbstractFactory.CreatehParameterElementFactory().Create(
                    this.i.GetElementAt(x.Key),
                    x.Value))
                .ToImmutableList());

            // L(i)
            this.L = parametersAbstractFactory.CreateLFactory().Create(
                this.Context.SurgeonMinimumNumberTimeBlocks
                .Select(x => parameterElementsAbstractFactory.CreateLParameterElementFactory().Create(
                    this.i.GetElementAt(x.Key),
                    x.Value))
                .ToImmutableList());

            // N(i)
            this.N = parametersAbstractFactory.CreateNFactory().Create(
                this.Context.SurgeonStrategicTargetNumberPatients
                .Select(x => parameterElementsAbstractFactory.CreateNParameterElementFactory().Create(
                    this.i.GetElementAt(x.Key),
                    x.Value))
                .ToImmutableList());

            // n(i, ω) calculated externally
            if (this.Context != null && this.Context.SurgeonScenarioMaximumNumberPatients != null)
            {
                this.n = parametersAbstractFactory.CreatenFactory().Create(
                    this.Context.SurgeonScenarioMaximumNumberPatients
                    .Select(x => parameterElementsAbstractFactory.CreatenParameterElementFactory().Create(
                        this.i.GetElementAt(x.Item1),
                        this.ω.GetElementAt(x.Item2),
                        x.Item3))
                    .ToImmutableList());
            }

            // p(i, l, ω)
            this.p = parametersAbstractFactory.CreatepFactory().Create(
                this.Context.SurgeonDayScenarioLengthOfStayProbabilities
                .Select(x => parameterElementsAbstractFactory.CreatepParameterElementFactory().Create(
                    this.i.GetElementAt(x.Item1),
                    this.l.GetElementAt(x.Item2),
                    this.ω.GetElementAt(x.Item3),
                    x.Item4))
                .ToImmutableList());

            // S(r)
            this.S = parametersAbstractFactory.CreateSFactory().Create(
                this.Context.SurgicalSpecialties
                .Select(x => parameterElementsAbstractFactory.CreateSParameterElementFactory().Create(
                    this.r.GetElementAt(x.Item1),
                    x.Item2.Select(w => this.i.GetElementAt(w)).ToImmutableList()))
                .ToImmutableList());

            // v
            this.v = parametersAbstractFactory.CreatevFactory().Create(
                this.Context.TimeBlockLength);

            // w1
            this.w1 = parametersAbstractFactory.Createw1Factory().Create(
                this.Context.GoalWeight1);

            // w2
            this.w2 = parametersAbstractFactory.Createw2Factory().Create(
                this.Context.GoalWeight2);

            // w3
            this.w3 = parametersAbstractFactory.Createw3Factory().Create(
                this.Context.GoalWeight3);

            // w4
            this.w4 = parametersAbstractFactory.Createw4Factory().Create(
                this.Context.GoalWeight4);

            // Π(i, j)
            this.Π = parametersAbstractFactory.CreateΠFactory().Create(
                this.Context.SurgeonOperatingRoomAvailabilities
                .Select(x => parameterElementsAbstractFactory.CreateΠParameterElementFactory().Create(
                    this.i.GetElementAt(x.Item1),
                    this.j.GetElementAt(x.Item2),
                    x.Item3))
                .ToImmutableList());

            // Ρ(ω)
            this.Ρ = parametersAbstractFactory.CreateΡFactory().Create(
                this.Context.ScenarioProbabilities
                .Select(x => parameterElementsAbstractFactory.CreateΡParameterElementFactory().Create(
                    this.ω.GetElementAt(x.Key),
                    x.Value))
                .ToImmutableList());

            // Φ(i, l, ω)
            this.Φ = parametersAbstractFactory.CreateΦFactory().Create(
                this.Context.SurgeonDayScenarioCumulativeNumberPatients
                .Select(x => parameterElementsAbstractFactory.CreateΦParameterElementFactory().Create(
                    this.i.GetElementAt(x.Item1),
                    this.l.GetElementAt(x.Item2),
                    this.ω.GetElementAt(x.Item3),
                    x.Item4))
                .ToImmutableList());

            // Ω(i, k)
            this.Ω = parametersAbstractFactory.CreateΩFactory().Create(
                this.Context.SurgeonDayAvailabilities
                .Select(x => parameterElementsAbstractFactory.CreateΩParameterElementFactory().Create(
                    this.i.GetElementAt(x.Item1),
                    this.k.GetElementAt(x.Item2),
                    x.Item3))
                .ToImmutableList());

            // Variables

            // d1Minus(i, ω)
            this.d1Minus = variablesAbstractFactory.Created1MinusFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.i.Value.Values, 
                    indexSet2: this.ω.Value.Values, 
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: (a, b) => int.MaxValue, 
                    variableTypeGenerator: (a, b) => VariableType.Integer));

            // d1Plus(i, ω)
            this.d1Plus = variablesAbstractFactory.Created1PlusFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.i.Value.Values, 
                    indexSet2: this.ω.Value.Values, 
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: (a, b) => int.MaxValue, 
                    variableTypeGenerator: (a, b) => VariableType.Integer)); 

            // d2Minus(i, j, k, ω)
            this.d2Minus = variablesAbstractFactory.Created2MinusFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.i.Value.Values, 
                    indexSet2: this.j.Value.Values, 
                    indexSet3: this.k.Value, 
                    indexSet4: this.ω.Value.Values,
                    lowerBoundGenerator: (a, b, c, d) => 0, 
                    upperBoundGenerator: (a, b, c, d) => double.MaxValue, 
                    variableTypeGenerator: (a, b, c, d) => VariableType.Continuous)); 

            // I(k, ω)
            this.I = variablesAbstractFactory.CreateIFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.k.Value, 
                    indexSet2: this.ω.Value.Values, 
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: (a, b) => double.MaxValue, 
                    variableTypeGenerator: (a, b) => VariableType.Continuous)); 

            // IMax(ω)
            this.IMax = variablesAbstractFactory.CreateIMaxFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.ω.Value.Values, 
                    lowerBoundGenerator: (a) => 0,
                    upperBoundGenerator: (a) => double.MaxValue, 
                    variableTypeGenerator: (a) => VariableType.Continuous)); 

            // IMin(ω)
            this.IMin = variablesAbstractFactory.CreateIMinFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model,
                    indexSet1: this.ω.Value.Values, 
                    lowerBoundGenerator: (a) => 0, 
                    upperBoundGenerator: (a) => double.MaxValue, 
                    variableTypeGenerator: (a) => VariableType.Continuous)); 

            // x(i, j, k)
            this.x = variablesAbstractFactory.CreatexFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().CreateBinary(
                    model: this.Model,
                    indexSet1: this.i.Value.Values, 
                    indexSet2: this.j.Value.Values,
                    indexSet3: this.k.Value)); 

            // Constraints

            // Constraints 1
            this.Model.AddConstraints(
                this.k.Value
                .Select(
                    w => constraintElementsAbstractFactory.CreateConstraints1ConstraintElementFactory().Create(
                        w,
                        this.ij,
                        this.Π,
                        this.x)
                    .Value));

            // Constraints 2
            this.Model.AddConstraints(
                this.j.Value.Values
                .Select(
                    w => constraintElementsAbstractFactory.CreateConstraints2ConstraintElementFactory().Create(
                        w,
                        this.ik,
                        this.Ω,
                        this.x)
                    .Value));

            // Constraints 3
            this.Model.AddConstraints(
                this.jk.Value
                .Select(
                    w => constraintElementsAbstractFactory.CreateConstraints3ConstraintElementFactory().Create(
                        w.jIndexElement,
                        w.kIndexElement,
                        this.i,
                        this.x)
                    .Value));

            // Constraints 4
            this.Model.AddConstraints(
                this.ik.Value
                .Select(
                    w => constraintElementsAbstractFactory.CreateConstraints4ConstraintElementFactory().Create(
                        w.iIndexElement,
                        w.kIndexElement,
                        this.j,
                        this.x)
                    .Value));

            // Constraints 5L
            this.Model.AddConstraints(
                this.i.Value.Values
                .Select(
                    w => constraintElementsAbstractFactory.CreateConstraints5LConstraintElementFactory().Create(
                        w,
                        this.jk,
                        this.L,
                        this.x)
                    .Value));

            // Constraints 5U
            this.Model.AddConstraints(
                this.i.Value.Values
                .Select(
                    w => constraintElementsAbstractFactory.CreateConstraints5UConstraintElementFactory().Create(
                        w,
                        this.jk,
                        this.H,
                        this.x)
                    .Value));

            // Constraints 6
            this.Model.AddConstraints(
                this.iω.Value
                .Select(
                    w => constraintElementsAbstractFactory.CreateConstraints6ConstraintElementFactory().Create(
                        w.iIndexElement,
                        w.ωIndexElement,
                        this.jk,
                        this.N,
                        this.n,
                        this.d1Minus,
                        this.d1Plus,
                        this.x)
                    .Value));

            // Constraints 7
            this.Model.AddConstraints(
                this.ijkω.Value
                .Select(
                    w => constraintElementsAbstractFactory.CreateConstraints7ConstraintElementFactory().Create(
                        w.iIndexElement,
                        w.jIndexElement,
                        w.kIndexElement,
                        w.ωIndexElement,
                        this.A,
                        this.n,
                        this.v,
                        this.d2Minus,
                        this.x)
                    .Value));

            // Constraints 8
            this.Model.AddConstraints(
                this.kω.Value
                .Select(
                    w => constraintElementsAbstractFactory.CreateConstraints8ConstraintElementFactory().Create(
                        w.kIndexElement,
                        w.ωIndexElement,
                        this.k,
                        this.l,
                        this.ilj,
                        parametersAbstractFactory.CreateΦFactory().Create(this.Φ.Value.Where(y => y.ωIndexElement == w.ωIndexElement).ToImmutableList()),
                        this.I,
                        this.x)
                    .Value));

            // Constraints 9
            this.Model.AddConstraints(
                this.r.Value.Values
                .Select(
                    w => constraintElementsAbstractFactory.CreateConstraints9ConstraintElementFactory().Create(
                        w,
                        this.ijk,
                        this.B,
                        this.S,
                        this.x)
                    .Value));

            foreach (IkIndexElement kIndexElement in this.k.Value)
            {
                foreach (IωIndexElement ωIndexElement in this.ω.Value.Values)
                {
                    this.Model.AddConstraint(this.IMax.Value[ωIndexElement] >= this.I.Value[kIndexElement, ωIndexElement]);

                    this.Model.AddConstraint(this.I.Value[kIndexElement, ωIndexElement] >= this.IMin.Value[ωIndexElement]);
                }
            }

            // Objective function
            this.Model.AddObjective(
                objectiveFunctionsAbstractFactory.CreateWGPMObjectiveFunctionFactory().Create(
                    dependenciesAbstractFactory.CreateObjectiveFactory(),
                    objectiveFunctionsAbstractFactory.CreateGoal1Factory().Create(
                        dependenciesAbstractFactory.CreateObjectiveFactory(),
                        this.iω,
                        this.w1,
                        this.Ρ,
                        this.d1Minus),
                    objectiveFunctionsAbstractFactory.CreateGoal2Factory().Create(
                        dependenciesAbstractFactory.CreateObjectiveFactory(),
                        this.ijkω,
                        this.w2,
                        this.Ρ,
                        this.d2Minus),
                    objectiveFunctionsAbstractFactory.CreateGoal3Factory().Create(
                        dependenciesAbstractFactory.CreateObjectiveFactory(),
                        this.k,
                        this.ω,
                        this.w3,
                        this.Ρ,
                        this.IMax),
                    objectiveFunctionsAbstractFactory.CreateGoal4Factory().Create(
                        dependenciesAbstractFactory.CreateObjectiveFactory(),
                        this.k,
                        this.ω,
                        this.w4,
                        this.Ρ,
                        this.IMax,
                        this.IMin))
                .Value);
        }

        /// <summary>
        /// Gets the Context instance.
        /// </summary>
        public IWGPMInputContext Context { get; }

        /// <summary>
        /// Gets the Model instance.
        /// </summary>
        public Model Model { get; }

        public Ie e { get; }

        public Ii i { get; }

        public Ij j { get; }

        public Ik k { get; }

        public Il l { get; }

        public Ir r { get; }

        public Iω ω { get; }

        public Iieω ieω { get; }

        public Iij ij { get; }

        public Iijk ijk { get; }

        public Iijkω ijkω { get; }

        public Iik ik { get; }

        public Iilj ilj { get; }

        public Iilω ilω { get; }

        public Iiω iω { get; }

        public Ijk jk { get; }

        public Ikω kω { get; }

        public IA A { get; }

        public IB B { get; }

        public ID D { get; }

        public If f { get; }

        public IH H { get; }

        public Ih h { get; }

        public IL L { get; }

        public IN N { get; }

        public In n { get; }

        public IO O { get; }

        public Ip p { get; }

        public IS S { get; }

        public Iv v { get; }

        public Iw1 w1 { get; }

        public Iw2 w2 { get; }

        public Iw3 w3 { get; }

        public Iw4 w4 { get; }

        public IΠ Π { get; }

        public IΡ Ρ { get; }

        public IΦ Φ { get; }

        public IΩ Ω { get; }

        public Id1Minus d1Minus { get; }

        public Id1Plus d1Plus { get; }

        public Id2Minus d2Minus { get; }

        public II I { get; }

        public IIMax IMax { get; }

        public IIMin IMin { get; }

        public Ix x { get; }
    }
}