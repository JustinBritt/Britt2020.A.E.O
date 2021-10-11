namespace Britt2020.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Britt2020.A.E.O.Factories.Variables;
    using Britt2020.A.E.O.InterfacesAbstractFactories;
    using Britt2020.A.E.O.InterfacesFactories.Variables;

    internal sealed class VariablesAbstractFactory : IVariablesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VariablesAbstractFactory()
        {
        }

        public Id1MinusFactory Created1MinusFactory()
        {
            Id1MinusFactory factory = null;

            try
            {
                factory = new d1MinusFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Id1PlusFactory Created1PlusFactory()
        {
            Id1PlusFactory factory = null;

            try
            {
                factory = new d1PlusFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Id2MinusFactory Created2MinusFactory()
        {
            Id2MinusFactory factory = null;

            try
            {
                factory = new d2MinusFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IIFactory CreateIFactory()
        {
            IIFactory factory = null;

            try
            {
                factory = new IFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IIMaxFactory CreateIMaxFactory()
        {
            IIMaxFactory factory = null;

            try
            {
                factory = new IMaxFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IIMinFactory CreateIMinFactory()
        {
            IIMinFactory factory = null;

            try
            {
                factory = new IMinFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IxFactory CreatexFactory()
        {
            IxFactory factory = null;

            try
            {
                factory = new xFactory();
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