namespace Britt2022.A.E.O.Factories.Parameters.LengthsOfStay
{
    using System;
 
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Classes.Parameters.LengthsOfStay;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.LengthsOfStay;
    using Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay;
    using Britt2022.A.E.O.InterfacesFactories.Parameters.LengthsOfStay;

    internal sealed class hFactory : IhFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public hFactory()
        {
        }

        public Ih Create(
            RedBlackTree<IiIndexElement, IhParameterElement> value)
        {
            Ih parameter = null;

            try
            {
                parameter = new h(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}