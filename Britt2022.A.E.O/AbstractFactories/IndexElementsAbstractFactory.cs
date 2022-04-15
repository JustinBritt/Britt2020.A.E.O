namespace Britt2022.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Factories.IndexElements;
    using Britt2022.A.E.O.InterfacesAbstractFactories;
    using Britt2022.A.E.O.InterfacesFactories.IndexElements;

    internal sealed class IndexElementsAbstractFactory : IIndexElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IndexElementsAbstractFactory()
        {
        }

        public IeIndexElementFactory CreateeIndexElementFactory()
        {
            IeIndexElementFactory factory = null;

            try
            {
                factory = new eIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IiIndexElementFactory CreateiIndexElementFactory()
        {
            IiIndexElementFactory factory = null;

            try
            {
                factory = new iIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IjIndexElementFactory CreatejIndexElementFactory()
        {
            IjIndexElementFactory factory = null;

            try
            {
                factory = new jIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IkIndexElementFactory CreatekIndexElementFactory()
        {
            IkIndexElementFactory factory = null;

            try
            {
                factory = new kIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IlIndexElementFactory CreatelIndexElementFactory()
        {
            IlIndexElementFactory factory = null;

            try
            {
                factory = new lIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IrIndexElementFactory CreaterIndexElementFactory()
        {
            IrIndexElementFactory factory = null;

            try
            {
                factory = new rIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IωIndexElementFactory CreateωIndexElementFactory()
        {
            IωIndexElementFactory factory = null;

            try
            {
                factory = new ωIndexElementFactory();
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