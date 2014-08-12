using NUnit.Framework;
using System;

namespace Concise.Core.Tests
{
	[TestFixture()]
	public class ObjectTests
	{
		object NotNullObj = new object();
		object NullObj = null;

		[Test()]
		public void IsNull_ReturnsTrue_OnNullObject()
		{
			bool expected = true;
			bool actual = NullObj.IsNull();

			Assert.AreEqual(expected, actual);
		}

		[Test()]
		public void IsNull_ReturnsFalse_OnNotNullObject()
		{
			bool expected = false;
			bool actual = NotNullObj.IsNull();

			Assert.AreEqual(expected, actual);
		}

	}
}

