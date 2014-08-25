using System;
using Concise.Core.Strings;

namespace Concise.Core.Numbers
{
    internal class DecimalMethods : IDecimalMethods
	{
        private readonly IStringMethods _stringMethods;

        public DecimalMethods()
        {
            _stringMethods = new StringMethods();
        }

        public decimal Write(decimal source)
        {
            return decimal.Parse(_stringMethods.Write(source.ToString()));
        }

        // =========

        public decimal WriteLine(decimal source)
        {
            return decimal.Parse(_stringMethods.WriteLine(source.ToString()));
        }

        // =========

        public decimal Ceiling(decimal source)
        {
            return Math.Ceiling(source);
        }
            
        // ==========

        public decimal Floor(decimal source)
        {
            return Math.Floor(source);
        }

        // ==========

        public decimal Abs(decimal source)
        {
            return Math.Abs(source);
        }

        // ==========

        public long ToInt(decimal source)
        {
            return (long)this.Floor(source);
        }
	}
}

