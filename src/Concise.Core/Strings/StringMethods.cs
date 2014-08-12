using System;

namespace Concise.Core.Strings
{
    internal class StringMethods : IStringMethods
	{
		public bool IsNothing(string source)
		{
			return (source == null || string.IsNullOrEmpty(source.Trim()));
		}

        public string FormatTo(string source, params string[] args)
        {
            return string.Format(source, args);
        }

        public string Write(string source)
        {
            Console.Write(source);
            return source;
        }

        public string WriteLine(string source)
        {
            Console.WriteLine(source);
            return source;
        }
	}
}

