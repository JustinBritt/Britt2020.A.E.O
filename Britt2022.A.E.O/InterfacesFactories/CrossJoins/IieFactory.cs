﻿namespace Britt2022.A.E.O.InterfacesFactories.CrossJoins
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.CrossJoinElements;
    using Britt2022.A.E.O.Interfaces.CrossJoins;

    public interface IieFactory
    {
        Iie Create(
            ImmutableList<IieCrossJoinElement> value);
    }
}