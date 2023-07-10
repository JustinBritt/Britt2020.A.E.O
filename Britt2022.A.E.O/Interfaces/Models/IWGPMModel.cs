﻿namespace Britt2022.A.E.O.Interfaces.Models
{
    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.Variables;

    public interface IWGPMModel
    {
        /// <summary>
        /// Gets the Model instance.
        /// </summary>
        Model Model { get; }

        Ik k { get; }

        Iω ω { get; }

        Iijk ijk { get; }

        Iijkω ijkω { get; }

        Iiω iω { get; }

        Ikω kω { get; }

        Id1Minus d1Minus { get; }

        Id1Plus d1Plus { get; }

        Id2Minus d2Minus { get; }

        II I { get; }

        IIMax IMax { get; }

        IIMin IMin { get; }

        Ix x { get; }
    }
}