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
	}
}

