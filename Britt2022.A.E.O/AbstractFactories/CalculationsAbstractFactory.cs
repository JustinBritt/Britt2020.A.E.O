namespace Britt2022.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Factories.Calculations.ScenarioNumberPatients;
    using Britt2022.A.E.O.Factories.Calculations.ScenarioTotalTimes;
    using Britt2022.A.E.O.Factories.Calculations.ScenarioUnderutilizations;
    using Britt2022.A.E.O.Factories.Calculations.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.Factories.Calculations.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.Factories.Calculations.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesAbstractFactories;
    using Britt2022.A.E.O.InterfacesFactories.Calculations.ScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesFactories.Calculations.ScenarioTotalTimes;
    using Britt2022.A.E.O.InterfacesFactories.Calculations.ScenarioUnderutilizations;
    using Britt2022.A.E.O.InterfacesFactories.Calculations.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.Calculations.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.Calculations.SurgeonScenarioNumberPatients;

    internal sealed class CalculationsAbstractFactory : ICalculationsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CalculationsAbstractFactory()
        {
        }

        public IScenarioNumberPatientsCalculationFactory CreateScenarioNumberPatientsCalculationFactory()
        {
            IScenarioNumberPatientsCalculationFactory factory = null;

            try
            {
                factory = new ScenarioNumberPatientsCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioNumberPatientsResultElementCalculationFactory CreateScenarioNumberPatientsResultElementCalculationFactory()
        {
            IScenarioNumberPatientsResultElementCalculationFactory factory = null;

            try
            {
                factory = new ScenarioNumberPatientsResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioTotalTimesCalculationFactory CreateScenarioTotalTimesCalculationFactory()
        {
            IScenarioTotalTimesCalculationFactory factory = null;

            try
            {
                factory = new ScenarioTotalTimesCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioTotalTimesResultElementCalculationFactory CreateScenarioTotalTimesResultElementCalculationFactory()
        {
            IScenarioTotalTimesResultElementCalculationFactory factory = null;

            try
            {
                factory = new ScenarioTotalTimesResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUnderutilizationsCalculationFactory CreateScenarioUnderutilizationsCalculationFactory()
        {
            IScenarioUnderutilizationsCalculationFactory factory = null;

            try
            {
                factory = new ScenarioUnderutilizationsCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUnderutilizationsResultElementCalculationFactory CreateScenarioUnderutilizationsResultElementCalculationFactory()
        {
            IScenarioUnderutilizationsResultElementCalculationFactory factory = null;

            try
            {
                factory = new ScenarioUnderutilizationsResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUnutilizedTimesCalculationFactory CreateScenarioUnutilizedTimesCalculationFactory()
        {
            IScenarioUnutilizedTimesCalculationFactory factory = null;

            try
            {
                factory = new ScenarioUnutilizedTimesCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUnutilizedTimesResultElementCalculationFactory CreateScenarioUnutilizedTimesResultElementCalculationFactory()
        {
            IScenarioUnutilizedTimesResultElementCalculationFactory factory = null;

            try
            {
                factory = new ScenarioUnutilizedTimesResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUtilizedTimesCalculationFactory CreateScenarioUtilizedTimesCalculationFactory()
        {
            IScenarioUtilizedTimesCalculationFactory factory = null;

            try
            {
                factory = new ScenarioUtilizedTimesCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUtilizedTimesResultElementCalculationFactory CreateScenarioUtilizedTimesResultElementCalculationFactory()
        {
            IScenarioUtilizedTimesResultElementCalculationFactory factory = null;

            try
            {
                factory = new ScenarioUtilizedTimesResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonScenarioNumberPatientsCalculationFactory CreateSurgeonScenarioNumberPatientsCalculationFactory()
        {
            ISurgeonScenarioNumberPatientsCalculationFactory factory = null;

            try
            {
                factory = new SurgeonScenarioNumberPatientsCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonScenarioNumberPatientsResultElementCalculationFactory CreateSurgeonScenarioNumberPatientsResultElementCalculationFactory()
        {
            ISurgeonScenarioNumberPatientsResultElementCalculationFactory factory = null;

            try
            {
                factory = new SurgeonScenarioNumberPatientsResultElementCalculationFactory();
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