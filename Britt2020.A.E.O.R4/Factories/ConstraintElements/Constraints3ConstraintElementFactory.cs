namespace Britt2020.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using Britt2020.A.E.O.Classes.ConstraintElements;
    using Britt2020.A.E.O.Interfaces.ConstraintElements;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Indices;
    using Britt2020.A.E.O.Interfaces.Variables;
    using Britt2020.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints3ConstraintElementFactory : IConstraints3ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints3ConstraintElementFactory()
        {
        }

        public IConstraints3ConstraintElement Create(
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement,
            Ii i,
            Ix x)
        {
            IConstraints3ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints3ConstraintElement(
                    jIndexElement,
                    kIndexElement,
                    i,
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