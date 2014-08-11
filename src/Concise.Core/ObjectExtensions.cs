using System;
using Concise.Core.Objects;

namespace Concise.Core
{
	public static class ObjectExtensions
	{
		private static IObjectMethods _objMethods;

		static ObjectExtensions()
		{
			_objMethods = new ObjectMethods();
		}

		public static bool IsNull(this object source)
		{
			return _objMethods.IsNull(source);
		}
	}
}

