using System;
using Concise.Core.Strings;

namespace Concise.Core
{
	public static class StringExtensions
	{
		private static IStringMethods _strMethods;

		static StringExtensions()
		{
			_strMethods = new StringMethods();
		}

		public static bool IsNothing(this string source)
		{
			return (_strMethods.IsNothing(source));
		}

        public static string FormatTo(this string source, params string[] args)
        {
            return _strMethods.FormatTo(source, args);
        }

        public static string Write(this string source)
        {
            return _strMethods.Write(source);
        }

        public static string WriteLine(this string source)
        {
            return _strMethods.WriteLine(source);
        }
	}
}

