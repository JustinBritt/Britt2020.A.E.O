namespace Britt2020.A.E.O.Factories.Variables
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Britt2020.A.E.O.Classes.Variables;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Variables;
    using Britt2020.A.E.O.InterfacesFactories.Variables;

    internal sealed class xFactory : IxFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xFactory()
        {
        }

        public Ix Create(
            VariableCollection<IiIndexElement, IjIndexElement, IkIndexElement> value)
        {
            Ix variable = null;

            try
            {
                variable = new x(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return variable;
        }
    }
}