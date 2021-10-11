namespace Britt2020.A.E.O.Classes.Indices
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Indices;

    internal sealed class k : Ik
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public k(
            ImmutableList<IkIndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IkIndexElement> Value { get; }

        public IkIndexElement GetElementAt(
            int value)
        {
            return this.Value
                .Where(x => x.Key == value)
                .SingleOrDefault();
        }

        public IkIndexElement GetElementAt(
            FhirDateTime value)
        {
            return this.Value
                .Where(x => x.Value == value)
                .SingleOrDefault();
        }

        public int GetT()
        {
            return this.Value
                .Select(x => x.Key)
                .Max();
        }
    }
}