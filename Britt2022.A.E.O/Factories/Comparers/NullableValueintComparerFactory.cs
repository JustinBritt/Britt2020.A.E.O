namespace Britt2022.A.E.O.Factories.Comparers
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.Comparers;
    using Britt2022.A.E.O.Interfaces.Comparers;
    using Britt2022.A.E.O.InterfacesFactories.Comparers;

    internal sealed class NullableValueintComparerFactory : INullableValueintComparerFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NullableValueintComparerFactory()
        {
        }

        public INullableValueintComparer Create()
        {
            INullableValueintComparer instance = null;

            try
            {
                instance = new NullableValueintComparer();
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