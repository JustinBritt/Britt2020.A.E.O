namespace Britt2022.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.StrategicTargets;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints6ConstraintElementFactory : IConstraints6ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints6ConstraintElementFactory()
        {
        }

        public IConstraints6ConstraintElement Create(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement,
            Ijk jk,
            IN N,
            In n,
            Id1Minus d1Minus,
            Id1Plus d1Plus,
            Ix x)
        {
            IConstraints6ConstraintElement instance = null;

            try
            {
                instance = new Constraints6ConstraintElement(
                    iIndexElement,
                    ωIndexElement,
                    jk,
                    N,
                    n,
                    d1Minus,
                    d1Plus,
                    x);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}