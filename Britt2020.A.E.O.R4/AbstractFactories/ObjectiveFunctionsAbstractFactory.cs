namespace Britt2020.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Britt2020.A.E.O.Factories.ObjectiveFunctions;
    using Britt2020.A.E.O.InterfacesAbstractFactories;
    using Britt2020.A.E.O.InterfacesFactories.ObjectiveFunctions;

    internal sealed class ObjectiveFunctionsAbstractFactory : IObjectiveFunctionsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveFunctionsAbstractFactory()
        {
        }

        public IGoal1Factory CreateGoal1Factory()
        {
            IGoal1Factory factory = null;

            try
            {
                factory = new Goal1Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IGoal2Factory CreateGoal2Factory()
        {
            IGoal2Factory factory = null;

            try
            {
                factory = new Goal2Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IGoal3Factory CreateGoal3Factory()
        {
            IGoal3Factory factory = null;

            try
            {
                factory = new Goal3Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IGoal4Factory CreateGoal4Factory()
        {
            IGoal4Factory factory = null;

            try
            {
                factory = new Goal4Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IWGPMObjectiveFunctionFactory CreateWGPMObjectiveFunctionFactory()
        {
            IWGPMObjectiveFunctionFactory factory = null;

            try
            {
                factory = new WGPMObjectiveFunctionFactory();
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