namespace Britt2022.A.E.O.Factories.Dependencies.OPTANO.Modeling.Optimization
{
    using System;

    using log4net;

    using global::OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class ModelScopeFactory : IModelScopeFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ModelScopeFactory()
        {
        }

        public ModelScope Create()
        {
            ModelScope instance = null;

            try
            {
                instance = new ModelScope();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }

        public ModelScope Create(
            global::OPTANO.Modeling.Optimization.Configuration.Configuration configuration)
        {
            ModelScope instance = null;

            try
            {
                instance = new ModelScope(
                    configuration);
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