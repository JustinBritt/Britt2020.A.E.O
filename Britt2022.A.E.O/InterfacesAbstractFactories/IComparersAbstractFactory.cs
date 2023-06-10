﻿namespace Britt2022.A.E.O.InterfacesAbstractFactories
{
    using Britt2022.A.E.O.InterfacesFactories.Comparers;

    public interface IComparersAbstractFactory
    {
        INullableValueintComparerFactory CreateNullableValueintComparerFactory();

        IOrganizationComparerFactory CreateOrganizationComparerFactory();
    }
}