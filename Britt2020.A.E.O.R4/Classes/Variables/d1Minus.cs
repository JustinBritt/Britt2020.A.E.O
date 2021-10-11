namespace Britt2020.A.E.O.Classes.Variables
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;
 
    using log4net;

    using OPTANO.Modeling.Optimization;

    using Britt2020.A.E.O.Interfaces.CrossJoins;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Variables;
    using Britt2020.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioDeviations;
    using Britt2020.A.E.O.InterfacesFactories.Results.SurgeonScenarioDeviations;

    internal sealed class d1Minus : Id1Minus
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1Minus(
            VariableCollection<IiIndexElement, IωIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IiIndexElement, IωIndexElement> Value { get; }

        public int GetElementAt(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement)
        {
            int value = 0;

            int rounded = (int)Math.Round(
                this.Value[iIndexElement, ωIndexElement].Value,
                0,
                MidpointRounding.AwayFromZero);

            if (this.Value[iIndexElement, ωIndexElement].Value.IsAlmost(rounded))
            {
                value = rounded;
            }

            return value;
        }

        public Interfaces.Results.SurgeonScenarioDeviations.Id1Minus GetElementsAt(
            Id1MinusResultElementFactory d1MinusResultElementFactory,
            Id1MinusFactory d1MinusFactory,
            Iiω iω)
        {
            return d1MinusFactory.Create(
                iω.Value
                .Select(
                    w => d1MinusResultElementFactory.Create(
                        w.iIndexElement,
                        w.ωIndexElement,
                        this.GetElementAt(
                            w.iIndexElement,
                            w.ωIndexElement)))
                .ToImmutableList());
        }
    }
}