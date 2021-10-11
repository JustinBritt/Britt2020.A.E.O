namespace Britt2020.A.E.O.Classes.Variables
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Britt2020.A.E.O.Interfaces.CrossJoins;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Variables;
    using Britt2020.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2020.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayScenarioDeviations;

    internal sealed class d2Minus : Id2Minus
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d2Minus(
            VariableCollection<IiIndexElement, IjIndexElement, IkIndexElement, IωIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IiIndexElement, IjIndexElement, IkIndexElement, IωIndexElement> Value { get; }

        public decimal GetElementAt(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement,
            IωIndexElement ωIndexElement)
        {
            return (decimal)this.Value[iIndexElement, jIndexElement, kIndexElement, ωIndexElement].Value;
        }

        public Interfaces.Results.SurgeonOperatingRoomDayScenarioDeviations.Id2Minus GetElementsAt(
            Id2MinusResultElementFactory d2MinusResultElementFactory,
            Id2MinusFactory d2MinusFactory,
            Iijkω ijkω)
        {
            return d2MinusFactory.Create(
                ijkω.Value
                .Select(
                    w => d2MinusResultElementFactory.Create(
                        w.iIndexElement,
                        w.jIndexElement,
                        w.kIndexElement,
                        w.ωIndexElement,
                        this.GetElementAt(
                            w.iIndexElement,
                            w.jIndexElement,
                            w.kIndexElement,
                            w.ωIndexElement)))
                .ToImmutableList());
        }
    }
}