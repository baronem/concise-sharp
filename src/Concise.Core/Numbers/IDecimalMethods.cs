using System;

namespace Concise.Core.Numbers
{
	internal interface IDecimalMethods
	{
		decimal Write(decimal source);
		decimal WriteLine(decimal source);
        decimal Ceiling(decimal source);
        decimal Floor(decimal source);
        decimal Abs(decimal source);
        long ToInt(decimal source);
	}
}

