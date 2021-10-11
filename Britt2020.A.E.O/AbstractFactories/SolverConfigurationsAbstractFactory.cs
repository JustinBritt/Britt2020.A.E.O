namespace Britt2020.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Britt2020.A.E.O.Factories.SolverConfigurations;
    using Britt2020.A.E.O.InterfacesAbstractFactories;
    using Britt2020.A.E.O.InterfacesFactories.SolverConfigurations;

    internal sealed class SolverConfigurationsAbstractFactory : ISolverConfigurationsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SolverConfigurationsAbstractFactory()
        {
        }

        public ISolverConfigurationFactory CreateSolverConfigurationFactory()
        {
            ISolverConfigurationFactory factory = null;

            try
            {
                factory = new SolverConfigurationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}