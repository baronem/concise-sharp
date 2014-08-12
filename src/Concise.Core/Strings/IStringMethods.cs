using System;

namespace Concise.Core.Strings
{
	internal interface IStringMethods
	{
		bool IsNothing(string source);
        string FormatTo(string source, params string[] args);
        string Write(string source);
        string WriteLine(string source);
	}
}

