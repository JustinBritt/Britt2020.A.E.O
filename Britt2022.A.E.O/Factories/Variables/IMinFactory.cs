namespace Britt2022.A.E.O.Factories.Variables
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Classes.Variables;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.Variables;

    internal sealed class IMinFactory : IIMinFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IMinFactory()
        {
        }

        public IIMin Create(
            VariableCollection<IωIndexElement> value)
        {
            IIMin variable = null;

            try
            {
                variable = new IMin(
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