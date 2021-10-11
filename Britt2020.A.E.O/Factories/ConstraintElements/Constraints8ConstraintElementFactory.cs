namespace Britt2020.A.E.O.Factories.ConstraintElements
{
    using System;
 
    using log4net;

    using Britt2020.A.E.O.Classes.ConstraintElements;
    using Britt2020.A.E.O.Interfaces.ConstraintElements;
    using Britt2020.A.E.O.Interfaces.CrossJoins;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Indices;
    using Britt2020.A.E.O.Interfaces.Parameters.LengthsOfStay;
    using Britt2020.A.E.O.Interfaces.Variables;
    using Britt2020.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints8ConstraintElementFactory : IConstraints8ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints8ConstraintElementFactory()
        {
        }

        public IConstraints8ConstraintElement Create(
            IkIndexElement kIndexElement,
            IωIndexElement ωIndexElement,
            Ik k,
            Il l,
            Iilj ilj,
            IΦ Φ,
            II I,
            Ix x)
        {
            IConstraints8ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints8ConstraintElement(
                    kIndexElement,
                    ωIndexElement,
                    k,
                    l,
                    ilj,
                    Φ,
                    I,
                    x);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constraintElement;
        }
    }
}