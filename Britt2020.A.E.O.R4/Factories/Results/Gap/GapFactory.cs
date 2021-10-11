namespace Britt2020.A.E.O.Factories.Results.Gap
{
    using System;

    using log4net;

    using Britt2020.A.E.O.Classes.Results.Gap;
    using Britt2020.A.E.O.Interfaces.Results.Gap;
    using Britt2020.A.E.O.InterfacesFactories.Results.Gap;

    internal sealed class GapFactory : IGapFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GapFactory()
        {
        }

        public IGap Create(
            decimal value)
        {
            IGap result = null;

            try
            {
                result = new Gap(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}