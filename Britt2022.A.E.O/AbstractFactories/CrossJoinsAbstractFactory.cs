namespace Britt2022.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Factories.CrossJoins;
    using Britt2022.A.E.O.InterfacesAbstractFactories;
    using Britt2022.A.E.O.InterfacesFactories.CrossJoins;

    internal sealed class CrossJoinsAbstractFactory : ICrossJoinsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CrossJoinsAbstractFactory()
        {
        }

        public IieFactory CreateieFactory()
        {
            IieFactory factory = null;

            try
            {
                factory = new ieFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IieωFactory CreateieωFactory()
        {
            IieωFactory factory = null;

            try
            {
                factory = new ieωFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IijFactory CreateijFactory()
        {
            IijFactory factory = null;

            try
            {
                factory = new ijFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IijkFactory CreateijkFactory()
        {
            IijkFactory factory = null;

            try
            {
                factory = new ijkFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IijkωFactory CreateijkωFactory()
        {
            IijkωFactory factory = null;

            try
            {
                factory = new ijkωFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IikFactory CreateikFactory()
        {
            IikFactory factory = null;

            try
            {
                factory = new ikFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IilFactory CreateilFactory()
        {
            IilFactory factory = null;

            try
            {
                factory = new ilFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IiljFactory CreateiljFactory()
        {
            IiljFactory factory = null;

            try
            {
                factory = new iljFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IilωFactory CreateilωFactory()
        {
            IilωFactory factory = null;

            try
            {
                factory = new ilωFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IiωFactory CreateiωFactory()
        {
            IiωFactory factory = null;

            try
            {
                factory = new iωFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IjkFactory CreatejkFactory()
        {
            IjkFactory factory = null;

            try
            {
                factory = new jkFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IkωFactory CreatekωFactory()
        {
            IkωFactory factory = null;

            try
            {
                factory = new kωFactory();
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