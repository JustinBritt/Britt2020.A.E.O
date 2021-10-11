namespace Britt2020.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Britt2020.A.E.O.Factories.Parameters.GoalWeights;
    using Britt2020.A.E.O.Factories.Parameters.LengthsOfStay;
    using Britt2020.A.E.O.Factories.Parameters.PreferencesOfSurgeons;
    using Britt2020.A.E.O.Factories.Parameters.ScenarioProbabilities;
    using Britt2020.A.E.O.Factories.Parameters.StrategicTargets;
    using Britt2020.A.E.O.Factories.Parameters.Surgeries;
    using Britt2020.A.E.O.Factories.Parameters.SurgicalSpecialties;
    using Britt2020.A.E.O.InterfacesAbstractFactories;
    using Britt2020.A.E.O.InterfacesFactories.Parameters.GoalWeights;
    using Britt2020.A.E.O.InterfacesFactories.Parameters.LengthsOfStay;
    using Britt2020.A.E.O.InterfacesFactories.Parameters.PreferencesOfSurgeons;
    using Britt2020.A.E.O.InterfacesFactories.Parameters.ScenarioProbabilities;
    using Britt2020.A.E.O.InterfacesFactories.Parameters.StrategicTargets;
    using Britt2020.A.E.O.InterfacesFactories.Parameters.Surgeries;
    using Britt2020.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialties;

    internal sealed class ParametersAbstractFactory : IParametersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParametersAbstractFactory()
        {
        }

        public IAFactory CreateAFactory()
        {
            IAFactory factory = null;

            try
            {
                factory = new AFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IBFactory CreateBFactory()
        {
            IBFactory factory = null;

            try
            {
                factory = new BFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IDFactory CreateDFactory()
        {
            IDFactory factory = null;

            try
            {
                factory = new DFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IfFactory CreatefFactory()
        {
            IfFactory factory = null;

            try
            {
                factory = new fFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IHFactory CreateHFactory()
        {
            IHFactory factory = null;

            try
            {
                factory = new HFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IhFactory CreatehFactory()
        {
            IhFactory factory = null;

            try
            {
                factory = new hFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ILFactory CreateLFactory()
        {
            ILFactory factory = null;

            try
            {
                factory = new LFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public INFactory CreateNFactory()
        {
            INFactory factory = null;

            try
            {
                factory = new NFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public InFactory CreatenFactory()
        {
            InFactory factory = null;

            try
            {
                factory = new nFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IOFactory CreateOFactory()
        {
            IOFactory factory = null;

            try
            {
                factory = new OFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IpFactory CreatepFactory()
        {
            IpFactory factory = null;

            try
            {
                factory = new pFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISFactory CreateSFactory()
        {
            ISFactory factory = null;

            try
            {
                factory = new SFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IvFactory CreatevFactory()
        {
            IvFactory factory = null;

            try
            {
                factory = new vFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Iw1Factory Createw1Factory()
        {
            Iw1Factory factory = null;

            try
            {
                factory = new w1Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Iw2Factory Createw2Factory()
        {
            Iw2Factory factory = null;

            try
            {
                factory = new w2Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Iw3Factory Createw3Factory()
        {
            Iw3Factory factory = null;

            try
            {
                factory = new w3Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Iw4Factory Createw4Factory()
        {
            Iw4Factory factory = null;

            try
            {
                factory = new w4Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΠFactory CreateΠFactory()
        {
            IΠFactory factory = null;

            try
            {
                factory = new ΠFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΡFactory CreateΡFactory()
        {
            IΡFactory factory = null;

            try
            {
                factory = new ΡFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΦFactory CreateΦFactory()
        {
            IΦFactory factory = null;

            try
            {
                factory = new ΦFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΩFactory CreateΩFactory()
        {
            IΩFactory factory = null;

            try
            {
                factory = new ΩFactory();
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