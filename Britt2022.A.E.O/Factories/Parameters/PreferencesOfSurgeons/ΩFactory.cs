namespace Britt2022.A.E.O.Factories.Parameters.PreferencesOfSurgeons
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Classes.Parameters.PreferencesOfSurgeons;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons;
    using Britt2022.A.E.O.Interfaces.Parameters.PreferencesOfSurgeons;
    using Britt2022.A.E.O.InterfacesFactories.Parameters.PreferencesOfSurgeons;

    internal sealed class ΩFactory : IΩFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΩFactory()
        {
        }

        public IΩ Create(
            RedBlackTree<IiIndexElement, RedBlackTree<IkIndexElement, IΩParameterElement>> value)
        {
            IΩ instance = null;

            try
            {
                instance = new Ω(
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