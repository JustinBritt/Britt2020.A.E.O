namespace Britt2022.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.StrategicTargets;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints5LConstraintElementFactory : IConstraints5LConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5LConstraintElementFactory()
        {
        }

        public IConstraints5LConstraintElement Create(
            IiIndexElement iIndexElement,
            Ijk jk,
            IL L,
            Ix x)
        {
            IConstraints5LConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints5LConstraintElement(
                    iIndexElement,
                    jk,
                    L,
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