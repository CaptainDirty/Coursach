using System;

namespace MathLibrary
{
    public class Formulas
    {
        public Formulas()
        {
            parameters = TemperatureDependenceOfParameters.GetParameters(tB);
        }

        public double W { get; set; }
        public double tB { get; set; }
        public double d { get; set; }

        Parameters parameters;

        public double Re() => Math.Round(W * d / parameters.V * Math.Pow(10, 6), 2);

        public double NuKor
        {
            get => Math.Round(0.21 * Math.Pow(Re(), 0.65), 2);
        }

        public double NuShakh
        {
            get => Math.Round(0.37 * Math.Pow(Re(), 0.6), 2);
        }

        public double a3r(double Nu) => Math.Round((Nu * parameters.Lambda * Math.Pow(10, -2) / d), 2);

    }
}
