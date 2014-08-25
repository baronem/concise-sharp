using System;
using Concise.Core.Numbers;

namespace Concise.Core
{
    public static class DecimalExtensions
    {
        private static IDecimalMethods _decimalMethods;

        static DecimalExtensions()
        {
            _decimalMethods = new DecimalMethods();
        }

        #region "Float"
        public static float Write(this float source)
        {
            return (float)_decimalMethods.Write((decimal)source);
        }
        public static float WriteLine(this float source)
        {
            return (float)_decimalMethods.WriteLine((decimal)source);
        }

        public static float Ceiling(this float source)
        {
            return (float)_decimalMethods.Ceiling((decimal)source);
        }

        public static float Floor(this float source)
        {
            return (float)_decimalMethods.Floor((decimal)source);
        }

        public static float Abs(this float source)
        {
            return (float)_decimalMethods.Abs((decimal)source);
        }

        public static long ToInt(this float source)
        {
            return _decimalMethods.ToInt((decimal)source);
        }
        #endregion

        #region "Double"
        public static double Write(this double source)
        {
            return (double)_decimalMethods.Write((decimal)source);
        }
        public static double WriteLine(this double source)
        {
            return (double)_decimalMethods.WriteLine((decimal)source);
        }

        public static double Ceiling(this double source)
        {
            return (double)_decimalMethods.Ceiling((decimal)source);
        }

        public static double Floor(this double source)
        {
            return (double)_decimalMethods.Floor((decimal)source);
        }

        public static double Abs(this double source)
        {
            return (double)_decimalMethods.Abs((decimal)source);
        }

        public static long ToInt(this double source)
        {
            return _decimalMethods.ToInt((decimal)source);
        }
        #endregion


        #region "Decimal"
        public static decimal Write(this decimal source)
        {
            return _decimalMethods.Write(source);
        }
        public static decimal WriteLine(this decimal source)
        {
            return _decimalMethods.WriteLine(source);
        }
        public static decimal Ceiling(this decimal source)
        {
            return _decimalMethods.Ceiling(source);
        }

        public static decimal Floor(this decimal source)
        {
            return _decimalMethods.Floor(source);
        }

        public static decimal Abs(this decimal source)
        {
            return _decimalMethods.Abs(source);
        }

        public static long ToInt(this decimal source)
        {
            return _decimalMethods.ToInt(source);
        }
        #endregion
    }
}

