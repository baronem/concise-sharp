using System;

namespace Concise.Core.Objects
{
	internal class ObjectMethods : IObjectMethods
	{
		public bool IsNull(object source)
		{
			return (source == null);
		}

	}
}

