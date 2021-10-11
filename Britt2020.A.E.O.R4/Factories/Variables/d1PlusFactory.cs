namespace Britt2020.A.E.O.Factories.Variables
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Britt2020.A.E.O.Classes.Variables;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Variables;
    using Britt2020.A.E.O.InterfacesFactories.Variables;

    internal sealed class d1PlusFactory : Id1PlusFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1PlusFactory()
        {
        }

        public Id1Plus Create(
            VariableCollection<IiIndexElement, IωIndexElement> value)
        {
            Id1Plus variable = null;

            try
            {
                variable = new d1Plus(
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