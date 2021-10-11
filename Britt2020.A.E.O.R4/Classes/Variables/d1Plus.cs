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

    internal sealed class d1Plus : Id1Plus
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1Plus(
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

        public Interfaces.Results.SurgeonScenarioDeviations.Id1Plus GetElementsAt(
            Id1PlusResultElementFactory d1PlusResultElementFactory,
            Id1PlusFactory d1PlusFactory,
            Iiω iω)
        {
            return d1PlusFactory.Create(
                iω.Value
                .Select(
                    w => d1PlusResultElementFactory.Create(
                        w.iIndexElement,
                        w.ωIndexElement,
                        this.GetElementAt(
                            w.iIndexElement,
                            w.ωIndexElement)))
                .ToImmutableList());
        }
    }
}