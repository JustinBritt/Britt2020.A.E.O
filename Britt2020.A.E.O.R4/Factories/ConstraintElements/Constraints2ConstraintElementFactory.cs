namespace Britt2020.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using Britt2020.A.E.O.Classes.ConstraintElements;
    using Britt2020.A.E.O.Interfaces.ConstraintElements;
    using Britt2020.A.E.O.Interfaces.CrossJoins;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Parameters.PreferencesOfSurgeons;
    using Britt2020.A.E.O.Interfaces.Variables;
    using Britt2020.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints2ConstraintElementFactory : IConstraints2ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints2ConstraintElementFactory()
        {
        }

        public IConstraints2ConstraintElement Create(
            IjIndexElement jIndexElement,
            Iik ik,
            IΩ Ω,
            Ix x)
        {
            IConstraints2ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints2ConstraintElement(
                    jIndexElement,
                    ik,
                    Ω,
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