using NUnit.Framework;
using System;
using Concise.Core;

namespace Concise.Core.Tests
{
	[TestFixture()]
	public class StringTests
	{
		string NullString = null;
		string PopulatedString = "abc123";
		string EmptyString = "";
		string WhitespaceString = "    ";

		[Test()]
		public void IsNothing_ReturnsTrue_OnNullString()
		{
			bool expected = true;
			bool actual = NullString.IsNothing();

			Assert.AreEqual(expected, actual);
		}

		[Test()]
		public void IsNothing_ReturnsTrue_OnEmptyString()
		{
			bool expected = true;
			bool actual = EmptyString.IsNothing();

			Assert.AreEqual(expected, actual);
		}

		[Test()]
		public void IsNothing_ReturnsTrue_OnWhitespaceString()
		{
			bool expected = true;
			bool actual = WhitespaceString.IsNothing();

			Assert.AreEqual(expected, actual);
		}

		[Test()]
		public void IsNothing_ReturnsFalse_OnPopulatedString()
		{
			bool expected = false;
			bool actual = PopulatedString.IsNothing();

			Assert.AreEqual(expected, actual);
		}

        [Test()]
        public void Format_FormatsCorrectly()
        {
            string arg1 = "one";
            string arg2 = "two";
            string template = "{0} is not {1}";

            string expected = string.Format(template, arg1, arg2);
            string actual = template.FormatTo(arg1, arg2);

            Assert.AreEqual(expected, actual);
        }
	}
}

