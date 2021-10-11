namespace Britt2020.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Britt2020.A.E.O.Factories.CrossJoinElements;
    using Britt2020.A.E.O.InterfacesAbstractFactories;
    using Britt2020.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class CrossJoinElementsAbstractFactory : ICrossJoinElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CrossJoinElementsAbstractFactory()
        {
        }

        public IieCrossJoinElementFactory CreateieCrossJoinElementFactory()
        {
            IieCrossJoinElementFactory factory = null;

            try
            {
                factory = new ieCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IieωCrossJoinElementFactory CreateieωCrossJoinElementFactory()
        {
            IieωCrossJoinElementFactory factory = null;

            try
            {
                factory = new ieωCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IijCrossJoinElementFactory CreateijCrossJoinElementFactory()
        {
            IijCrossJoinElementFactory factory = null;

            try
            {
                factory = new ijCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IijkCrossJoinElementFactory CreateijkCrossJoinElementFactory()
        {
            IijkCrossJoinElementFactory factory = null;

            try
            {
                factory = new ijkCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IijkωCrossJoinElementFactory CreateijkωCrossJoinElementFactory()
        {
            IijkωCrossJoinElementFactory factory = null;

            try
            {
                factory = new ijkωCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IikCrossJoinElementFactory CreateikCrossJoinElementFactory()
        {
            IikCrossJoinElementFactory factory = null;

            try
            {
                factory = new ikCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IilCrossJoinElementFactory CreateilCrossJoinElementFactory()
        {
            IilCrossJoinElementFactory factory = null;

            try
            {
                factory = new ilCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IiljCrossJoinElementFactory CreateiljCrossJoinElementFactory()
        {
            IiljCrossJoinElementFactory factory = null;

            try
            {
                factory = new iljCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IilωCrossJoinElementFactory CreateilωCrossJoinElementFactory()
        {
            IilωCrossJoinElementFactory factory = null;

            try
            {
                factory = new ilωCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IiωCrossJoinElementFactory CreateiωCrossJoinElementFactory()
        {
            IiωCrossJoinElementFactory factory = null;

            try
            {
                factory = new iωCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IjkCrossJoinElementFactory CreatejkCrossJoinElementFactory()
        {
            IjkCrossJoinElementFactory factory = null;

            try
            {
                factory = new jkCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IkωCrossJoinElementFactory CreatekωCrossJoinElementFactory()
        {
            IkωCrossJoinElementFactory factory = null;

            try
            {
                factory = new kωCrossJoinElementFactory();
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