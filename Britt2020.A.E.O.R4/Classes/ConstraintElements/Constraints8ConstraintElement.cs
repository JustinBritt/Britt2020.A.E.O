namespace Britt2020.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Britt2020.A.E.O.Interfaces.ConstraintElements;
    using Britt2020.A.E.O.Interfaces.CrossJoins;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Indices;
    using Britt2020.A.E.O.Interfaces.Parameters.LengthsOfStay;
    using Britt2020.A.E.O.Interfaces.Variables;

    internal sealed class Constraints8ConstraintElement : IConstraints8ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints8ConstraintElement(
            IkIndexElement kIndexElement,
            IωIndexElement ωIndexElement,
            Ik k,
            Il l,
            Iilj ilj,
            IΦ Φ,
            II I,
            Ix x)
        {
            Expression LHS = I.Value[kIndexElement, ωIndexElement];

            // 1_k
            Expression RHS = 
                Expression.Sum(
                    ilj.Value
                    .Where(
                        w =>
                        w.lIndexElement.Value.Value.Value >= 1
                        &&
                        w.lIndexElement.Value.Value.Value <= kIndexElement.Key)
                    .Select(
                        w => 
                        Φ.GetElementAtAsdouble(
                            w.iIndexElement,
                            l.GetElementAt(
                                kIndexElement.Key - w.lIndexElement.Value.Value.Value),
                            ωIndexElement)
                        *
                        x.Value[
                            w.iIndexElement,
                            w.jIndexElement,
                            k.GetElementAt(
                                w.lIndexElement.Value.Value.Value)]))
                +
                // kPlus1_T
                Expression.Sum(
                    ilj.Value
                    .Where(
                        w =>
                        w.lIndexElement.Value.Value.Value > kIndexElement.Key)
                    .Select(
                        w =>
                        Φ.GetElementAtAsdouble(
                            w.iIndexElement,
                            l.GetElementAt(
                                kIndexElement.Key + k.GetT() - w.lIndexElement.Value.Value.Value),
                            ωIndexElement)
                        *
                        x.Value[
                            w.iIndexElement,
                            w.jIndexElement,
                            k.GetElementAt(
                                w.lIndexElement.Value.Value.Value)]));

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}