namespace Britt2022.A.E.O.Classes.Variables
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardCensuses;

    internal sealed class IMin : IIMin
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IMin(
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

        public Interfaces.Results.ScenarioRecoveryWardCensuses.IIMin GetElementsAt(
            IIMinResultElementFactory IMinResultElementFactory,
            IIMinFactory IMinFactory,
            Iω ω)
        {
            return IMinFactory.Create(
                ω.Value.Values
                .Select(
                    w => IMinResultElementFactory.Create(
                        w,
                        this.GetElementAt(
                            w)))
                .ToImmutableList());
        }
    }
}