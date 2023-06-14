namespace Britt2022.A.E.O.Factories.Dependencies.OPTANO.Modeling.Optimization
{
    using System;

    using log4net;

    using global::OPTANO.Modeling.Optimization;
    using global::OPTANO.Modeling.Optimization.Enums;

    using Britt2022.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class VariableFactory : IVariableFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VariableFactory()
        {
        }

        public Variable Create()
        {
            Variable instance = null;

            try
            {
                instance = new Variable();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }

        public Variable Create(
            double lowerbound,
            VariableType type,
            double upperbound)
        {
            Variable instance = null;

            try
            {
                instance = new Variable(
                    lowerbound: lowerbound,
                    upperbound: upperbound,
                    type: type);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }

        public Variable Create(
            double lowerbound,
            string name,
            VariableType type,
            double upperbound)
        {
            Variable instance = null;

            try
            {
                instance = new Variable(
                    name: name,
                    lowerbound: lowerbound,
                    upperbound: upperbound,
                    type: type);
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