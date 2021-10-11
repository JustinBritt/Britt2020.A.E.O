namespace Britt2020.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Britt2020.A.E.O.Factories.Indices;
    using Britt2020.A.E.O.InterfacesAbstractFactories;
    using Britt2020.A.E.O.InterfacesFactories.Indices;

    internal sealed class IndicesAbstractFactory : IIndicesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IndicesAbstractFactory()
        {
        }

        public IeFactory CreateeFactory()
        {
            IeFactory factory = null;

            try
            {
                factory = new eFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IiFactory CreateiFactory()
        {
            IiFactory factory = null;

            try
            {
                factory = new iFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IjFactory CreatejFactory()
        {
            IjFactory factory = null;

            try
            {
                factory = new jFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IkFactory CreatekFactory()
        {
            IkFactory factory = null;

            try
            {
                factory = new kFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IlFactory CreatelFactory()
        {
            IlFactory factory = null;

            try
            {
                factory = new lFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IrFactory CreaterFactory()
        {
            IrFactory factory = null;

            try
            {
                factory = new rFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IωFactory CreateωFactory()
        {
            IωFactory factory = null;

            try
            {
                factory = new ωFactory();
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