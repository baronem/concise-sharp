using System;

namespace Concise.Core.Strings
{
	internal class StringMethods : IStringMethods
	{
		public bool IsNothing(string source)
		{
			return (source == null || string.IsNullOrEmpty(source.Trim()));
		}
	}
}

