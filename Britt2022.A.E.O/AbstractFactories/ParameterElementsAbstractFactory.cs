namespace Britt2022.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Factories.ParameterElements.LengthsOfStay;
    using Britt2022.A.E.O.Factories.ParameterElements.PreferencesOfSurgeons;
    using Britt2022.A.E.O.Factories.ParameterElements.ScenarioProbabilities;
    using Britt2022.A.E.O.Factories.ParameterElements.StrategicTargets;
    using Britt2022.A.E.O.Factories.ParameterElements.Surgeries;
    using Britt2022.A.E.O.Factories.ParameterElements.SurgicalSpecialties;
    using Britt2022.A.E.O.InterfacesAbstractFactories;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.LengthsOfStay;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.PreferencesOfSurgeons;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.ScenarioProbabilities;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.StrategicTargets;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.Surgeries;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties;

    internal sealed class ParameterElementsAbstractFactory : IParameterElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParameterElementsAbstractFactory()
        {
        }

        public IAParameterElementFactory CreateAParameterElementFactory()
        {
            IAParameterElementFactory factory = null;

            try
            {
                factory = new AParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IBParameterElementFactory CreateBParameterElementFactory()
        {
            IBParameterElementFactory factory = null;

            try
            {
                factory = new BParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IDParameterElementFactory CreateDParameterElementFactory()
        {
            IDParameterElementFactory factory = null;

            try
            {
                factory = new DParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IfParameterElementFactory CreatefParameterElementFactory()
        {
            IfParameterElementFactory factory = null;

            try
            {
                factory = new fParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IHParameterElementFactory CreateHParameterElementFactory()
        {
            IHParameterElementFactory factory = null;

            try
            {
                factory = new HParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IhParameterElementFactory CreatehParameterElementFactory()
        {
            IhParameterElementFactory factory = null;

            try
            {
                factory = new hParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ILParameterElementFactory CreateLParameterElementFactory()
        {
            ILParameterElementFactory factory = null;

            try
            {
                factory = new LParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public INParameterElementFactory CreateNParameterElementFactory()
        {
            INParameterElementFactory factory = null;

            try
            {
                factory = new NParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public InParameterElementFactory CreatenParameterElementFactory()
        {
            InParameterElementFactory factory = null;

            try
            {
                factory = new nParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IOParameterElementFactory CreateOParameterElementFactory()
        {
            IOParameterElementFactory factory = null;

            try
            {
                factory = new OParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IpParameterElementFactory CreatepParameterElementFactory()
        {
            IpParameterElementFactory factory = null;

            try
            {
                factory = new pParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISParameterElementFactory CreateSParameterElementFactory()
        {
            ISParameterElementFactory factory = null;

            try
            {
                factory = new SParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΠParameterElementFactory CreateΠParameterElementFactory()
        {
            IΠParameterElementFactory factory = null;

            try
            {
                factory = new ΠParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΡParameterElementFactory CreateΡParameterElementFactory()
        {
            IΡParameterElementFactory factory = null;

            try
            {
                factory = new ΡParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΦParameterElementFactory CreateΦParameterElementFactory()
        {
            IΦParameterElementFactory factory = null;

            try
            {
                factory = new ΦParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΩParameterElementFactory CreateΩParameterElementFactory()
        {
            IΩParameterElementFactory factory = null;

            try
            {
                factory = new ΩParameterElementFactory();
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