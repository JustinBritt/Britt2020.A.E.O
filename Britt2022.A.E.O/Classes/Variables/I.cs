namespace Britt2022.A.E.O.Classes.Variables
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardCensuses;

    internal sealed class I : II
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public I(
            VariableCollection<IkIndexElement, IωIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IkIndexElement, IωIndexElement> Value { get; }

        public decimal GetElementAt(
            IkIndexElement kIndexElement,
            IωIndexElement ωIndexElement)
        {
            return (decimal)this.Value[kIndexElement, ωIndexElement].Value;
        }

        public Interfaces.Results.DayScenarioRecoveryWardCensuses.II GetElementsAt(
            IIResultElementFactory IResultElementFactory,
            IIFactory IFactory,
            Ikω kω)
        {
            return IFactory.Create(
                kω.Value
                .Select(
                    w => IResultElementFactory.Create(
                        w.kIndexElement,
                        w.ωIndexElement,
                        this.GetElementAt(
                            w.kIndexElement,
                            w.ωIndexElement)))
                .ToImmutableList());
        }
    }
}