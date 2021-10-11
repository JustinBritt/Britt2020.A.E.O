namespace Britt2020.A.E.O.Classes.Variables
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Indices;
    using Britt2020.A.E.O.Interfaces.Variables;
    using Britt2020.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2020.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardCensuses;

    internal sealed class IMax : IIMax
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IMax(
            VariableCollection<IωIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IωIndexElement> Value { get; }

        public decimal GetElementAt(
            IωIndexElement ωIndexElement)
        {
            return (decimal)this.Value[ωIndexElement].Value;
        }

        public Interfaces.Results.ScenarioRecoveryWardCensuses.IIMax GetElementsAt(
            IIMaxResultElementFactory IMaxResultElementFactory,
            IIMaxFactory IMaxFactory,
            Iω ω)
        {
            return IMaxFactory.Create(
                ω.Value
                .Select(
                    w => IMaxResultElementFactory.Create(
                        w,
                        this.GetElementAt(
                            w)))
                .ToImmutableList());
        }
    }
}