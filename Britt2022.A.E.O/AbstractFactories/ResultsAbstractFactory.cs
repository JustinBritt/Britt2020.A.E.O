namespace Britt2022.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Factories.Results.BestBound;
    using Britt2022.A.E.O.Factories.Results.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.Factories.Results.Gap;
    using Britt2022.A.E.O.Factories.Results.NumberOfExploredNodes;
    using Britt2022.A.E.O.Factories.Results.ObjectiveValue;
    using Britt2022.A.E.O.Factories.Results.OverallWallTime;
    using Britt2022.A.E.O.Factories.Results.ScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.Factories.Results.ScenarioTotalTimes;
    using Britt2022.A.E.O.Factories.Results.ScenarioUnderutilizations;
    using Britt2022.A.E.O.Factories.Results.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.Factories.Results.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.Factories.Results.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.Factories.Results.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.E.O.Factories.Results.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.InterfacesAbstractFactories;
    using Britt2022.A.E.O.InterfacesFactories.Results.BestBound;
    using Britt2022.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.Results.Gap;
    using Britt2022.A.E.O.InterfacesFactories.Results.NumberOfExploredNodes;
    using Britt2022.A.E.O.InterfacesFactories.Results.ObjectiveValue;
    using Britt2022.A.E.O.InterfacesFactories.Results.OverallWallTime;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioTotalTimes;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioUnderutilizations;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.E.O.InterfacesFactories.Results.SurgeonScenarioDeviations;

    internal sealed class ResultsAbstractFactory : IResultsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResultsAbstractFactory()
        {
        }

        public IBestBoundFactory CreateBestBoundFactory()
        {
            IBestBoundFactory factory = null;

            try
            {
                factory = new BestBoundFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
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

        public IGapFactory CreateGapFactory()
        {
            IGapFactory factory = null;

            try
            {
                factory = new GapFactory();
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

        public INumberOfExploredNodesFactory CreateNumberOfExploredNodesFactory()
        {
            INumberOfExploredNodesFactory factory = null;

            try
            {
                factory = new NumberOfExploredNodesFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IObjectiveValueFactory CreateObjectiveValueFactory()
        {
            IObjectiveValueFactory factory = null;

            try
            {
                factory = new ObjectiveValueFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IOverallWallTimeFactory CreateOverallWallTimeFactory()
        {
            IOverallWallTimeFactory factory = null;

            try
            {
                factory = new OverallWallTimeFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioTotalTimesFactory CreateScenarioTotalTimesFactory()
        {
            IScenarioTotalTimesFactory factory = null;

            try
            {
                factory = new ScenarioTotalTimesFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUtilizedTimesFactory CreateScenarioUtilizedTimesFactory()
        {
            IScenarioUtilizedTimesFactory factory = null;

            try
            {
                factory = new ScenarioUtilizedTimesFactory();
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