namespace Britt2022.A.E.O.InterfacesAbstractFactories
{
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.LengthsOfStay;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.PreferencesOfSurgeons;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.ScenarioProbabilities;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.StrategicTargets;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.Surgeries;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties;

    public interface IParameterElementsAbstractFactory
    {
        IAParameterElementFactory CreateAParameterElementFactory();

        IBParameterElementFactory CreateBParameterElementFactory();

        IDParameterElementFactory CreateDParameterElementFactory();

        IfParameterElementFactory CreatefParameterElementFactory();

        IHParameterElementFactory CreateHParameterElementFactory();

        IhParameterElementFactory CreatehParameterElementFactory();

        ILParameterElementFactory CreateLParameterElementFactory();

        INParameterElementFactory CreateNParameterElementFactory();

        InParameterElementFactory CreatenParameterElementFactory();

        IOParameterElementFactory CreateOParameterElementFactory();

        IpParameterElementFactory CreatepParameterElementFactory();

        ISParameterElementFactory CreateSParameterElementFactory();

        IΠParameterElementFactory CreateΠParameterElementFactory();

        IΡParameterElementFactory CreateΡParameterElementFactory();

        IΦParameterElementFactory CreateΦParameterElementFactory();

        IΩParameterElementFactory CreateΩParameterElementFactory();
    }
}