namespace Britt2022.A.E.O.Classes.Parameters.SurgicalSpecialties
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using Britt2022.A.E.O.Interfaces.Parameters.SurgicalSpecialties;

    internal sealed class S : IS
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S(
            ImmutableList<ISParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISParameterElement> Value { get; }

        public bool IsSurgeonMemberOfSurgicalSpecialty(
            IiIndexElement iIndexElement,
            IrIndexElement rIndexElement)
        {
            return this.Value
                .Where(x => x.rIndexElement == rIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault()
                .Contains(iIndexElement);
        }
    }
}