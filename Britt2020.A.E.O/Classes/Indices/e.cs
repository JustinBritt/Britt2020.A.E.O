namespace Britt2020.A.E.O.Classes.Indices
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Indices;

    internal sealed class e : Ie
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public e(
            ImmutableList<IeIndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IeIndexElement> Value { get; }

        public IeIndexElement GetElementAt(
            PositiveInt value)
        {
            return this.Value
                .Where(x => x.Value == value)
                .SingleOrDefault();
        }
    }
}