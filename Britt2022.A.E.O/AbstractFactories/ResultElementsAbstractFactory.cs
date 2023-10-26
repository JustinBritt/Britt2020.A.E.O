namespace Britt2022.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Factories.ResultElements.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.Factories.ResultElements.ScenarioNumberPatients;
    using Britt2022.A.E.O.Factories.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.Factories.ResultElements.ScenarioTotalTimes;
    using Britt2022.A.E.O.Factories.ResultElements.ScenarioUnderutilizations;
    using Britt2022.A.E.O.Factories.ResultElements.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.Factories.ResultElements.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.Factories.ResultElements.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.Factories.ResultElements.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.E.O.Factories.ResultElements.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.InterfacesAbstractFactories;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalTimes;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioUnderutilizations;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioDeviations;

    internal sealed class ResultElementsAbstractFactory : IResultElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResultElementsAbstractFactory()
        {
        }

        public Id1MinusResultElementFactory Created1MinusResultElementFactory()
        {
            Id1MinusResultElementFactory factory = null;

            try
            {
                factory = new d1MinusResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Id1PlusResultElementFactory Created1PlusResultElementFactory()
        {
            Id1PlusResultElementFactory factory = null;

            try
            {
                factory = new d1PlusResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Id2MinusResultElementFactory Created2MinusResultElementFactory()
        {
            Id2MinusResultElementFactory factory = null;

            try
            {
                factory = new d2MinusResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IIResultElementFactory CreateIResultElementFactory()
        {
            IIResultElementFactory factory = null;

            try
            {
                factory = new IResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IIMaxResultElementFactory CreateIMaxResultElementFactory()
        {
            IIMaxResultElementFactory factory = null;

            try
            {
                factory = new IMaxResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IIMinResultElementFactory CreateIMinResultElementFactory()
        {
            IIMinResultElementFactory factory = null;

            try
            {
                factory = new IMinResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioNumberPatientsResultElementFactory CreateScenarioNumberPatientsResultElementFactory()
        {
            IScenarioNumberPatientsResultElementFactory factory = null;

            try
            {
                factory = new ScenarioNumberPatientsResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioTotalTimesResultElementFactory CreateScenarioTotalTimesResultElementFactory()
        {
            IScenarioTotalTimesResultElementFactory factory = null;

            try
            {
                factory = new ScenarioTotalTimesResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUnderutilizationsResultElementFactory CreateScenarioUnderutilizationsResultElementFactory()
        {
            IScenarioUnderutilizationsResultElementFactory factory = null;

            try
            {
                factory = new ScenarioUnderutilizationsResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUnutilizedTimesResultElementFactory CreateScenarioUnutilizedTimesResultElementFactory()
        {
            IScenarioUnutilizedTimesResultElementFactory factory = null;

            try
            {
                factory = new ScenarioUnutilizedTimesResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUtilizedTimesResultElementFactory CreateScenarioUtilizedTimesResultElementFactory()
        {
            IScenarioUtilizedTimesResultElementFactory factory = null;

            try
            {
                factory = new ScenarioUtilizedTimesResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IxResultElementFactory CreatexResultElementFactory()
        {
            IxResultElementFactory factory = null;

            try
            {
                factory = new xResultElementFactory();
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