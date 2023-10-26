namespace Britt2022.A.E.O.Factories.Results.SurgeonScenarioNumberPatients
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2022.A.E.O.Classes.Results.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesFactories.Results.SurgeonScenarioNumberPatients;

    internal sealed class SurgeonScenarioNumberPatientsFactory : ISurgeonScenarioNumberPatientsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioNumberPatientsFactory()
        {
        }

        public ISurgeonScenarioNumberPatients Create(
            ImmutableList<ISurgeonScenarioNumberPatientsResultElement> value)
        {
            ISurgeonScenarioNumberPatients instance = null;

            try
            {
                instance = new SurgeonScenarioNumberPatients(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}