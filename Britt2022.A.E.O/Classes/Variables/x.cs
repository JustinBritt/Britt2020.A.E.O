namespace Britt2022.A.E.O.Classes.Variables
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments;

    internal sealed class x : Ix
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public x(
            VariableCollection<IiIndexElement, IjIndexElement, IkIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IiIndexElement, IjIndexElement, IkIndexElement> Value { get; }

        public bool GetElementAt(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement)
        {
            bool value = false;

            if (this.Value[iIndexElement, jIndexElement, kIndexElement].Value.IsAlmost(1))
            {
                value = true;
            }

            return value;
        }

        public Interfaces.Results.SurgeonOperatingRoomDayAssignments.Ix GetElementsAt(
            IxResultElementFactory xResultElementFactory,
            IxFactory xFactory,
            Iijk ijk)
        {
            return xFactory.Create(
                ijk.Value
                .Select(
                    w => xResultElementFactory.Create(
                        w.iIndexElement,
                        w.jIndexElement,
                        w.kIndexElement,
                        this.GetElementAt(
                            w.iIndexElement,
                            w.jIndexElement,
                            w.kIndexElement)))
                .ToImmutableList());
        }
    }
}