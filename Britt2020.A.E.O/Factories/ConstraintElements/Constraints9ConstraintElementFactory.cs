namespace Britt2020.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using Britt2020.A.E.O.Classes.ConstraintElements;
    using Britt2020.A.E.O.Interfaces.ConstraintElements;
    using Britt2020.A.E.O.Interfaces.CrossJoins;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Parameters.StrategicTargets;
    using Britt2020.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using Britt2020.A.E.O.Interfaces.Variables;
    using Britt2020.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints9ConstraintElementFactory : IConstraints9ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints9ConstraintElementFactory()
        {
        }

        public IConstraints9ConstraintElement Create(
            IrIndexElement rIndexElement,
            Iijk ijk,
            IB B,
            IS S,
            Ix x)
        {
            IConstraints9ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints9ConstraintElement(
                    rIndexElement,
                    ijk,
                    B,
                    S,
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