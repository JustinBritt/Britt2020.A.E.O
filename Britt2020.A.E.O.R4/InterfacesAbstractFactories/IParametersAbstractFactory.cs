namespace Britt2020.A.E.O.InterfacesAbstractFactories
{
    using Britt2020.A.E.O.InterfacesFactories.Parameters.GoalWeights;
    using Britt2020.A.E.O.InterfacesFactories.Parameters.LengthsOfStay;
    using Britt2020.A.E.O.InterfacesFactories.Parameters.PreferencesOfSurgeons;
    using Britt2020.A.E.O.InterfacesFactories.Parameters.ScenarioProbabilities;
    using Britt2020.A.E.O.InterfacesFactories.Parameters.StrategicTargets;
    using Britt2020.A.E.O.InterfacesFactories.Parameters.Surgeries;
    using Britt2020.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialties;

    public interface IParametersAbstractFactory
    {
        IAFactory CreateAFactory();

        IBFactory CreateBFactory();

        IDFactory CreateDFactory();

        IfFactory CreatefFactory();

        IHFactory CreateHFactory();

        IhFactory CreatehFactory();

        ILFactory CreateLFactory();

        INFactory CreateNFactory();

        InFactory CreatenFactory();

        IOFactory CreateOFactory();

        IpFactory CreatepFactory();

        ISFactory CreateSFactory();

        IvFactory CreatevFactory();

        Iw1Factory Createw1Factory();

        Iw2Factory Createw2Factory();

        Iw3Factory Createw3Factory();

        Iw4Factory Createw4Factory();

        IΠFactory CreateΠFactory();

        IΡFactory CreateΡFactory();

        IΦFactory CreateΦFactory();

        IΩFactory CreateΩFactory();
    }
}