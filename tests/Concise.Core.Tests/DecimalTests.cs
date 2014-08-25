using NUnit.Framework;
using System;
using Concise.Core;

namespace Concise.Core.Tests
{
    [TestFixture()]
    public class DecimalTests
    {
        private readonly decimal _dec = 1.2222m;

        #region "Write"
        [Test()]
        public void Write_ReturnsCorrectValueAfterPrinting_OnFloat()
        {
            float expected = (float)_dec;
            var actual = expected.Write();

            Assert.AreEqual(expected.GetType(), actual.GetType());
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Write_ReturnsCorrectValueAfterPrinting_OnDouble()
        {
            double expected = (double)_dec;
            var actual = expected.Write();

            Assert.AreEqual(expected.GetType(), actual.GetType());
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Write_ReturnsCorrectValueAfterPrinting_OnDecimal()
        {
            decimal expected = (decimal)_dec;
            var actual = expected.Write();

            Assert.AreEqual(expected.GetType(), actual.GetType());
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region WriteLine
        [Test()]
        public void WriteLine_ReturnsCorrectValueAfterPrinting_OnFloat()
        {
            float expected = (float)_dec;
            var actual = expected.WriteLine();

            Assert.AreEqual(expected.GetType(), actual.GetType());
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void WriteLine_ReturnsCorrectValueAfterPrinting_OnDouble()
        {
            double expected = (double)_dec;
            var actual = expected.WriteLine();

            Assert.AreEqual(expected.GetType(), actual.GetType());
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void WriteLine_ReturnsCorrectValueAfterPrinting_OnDecimal()
        {
            decimal expected = (decimal)_dec;
            var actual = expected.WriteLine();

            Assert.AreEqual(expected.GetType(), actual.GetType());
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region Floor
        [Test()]
        public void Floor_ReturnsCorrectInt_OnFloat()
        {
            int expected = (int)Math.Floor(_dec);
            float actual = ((float)_dec).Floor();

            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Floor_ReturnsCorrectInt_OnDouble()
        {
            int expected = (int)Math.Floor(_dec);
            double actual = ((double)_dec).Floor();

            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Floor_ReturnsCorrectInt_OnDecimal()
        {
            int expected = (int)Math.Floor(_dec);
            decimal actual = ((decimal)_dec).Floor();

            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region Ceiling
        [Test()]
        public void Ceiling_ReturnsCorrectInt_OnFloat()
        {
            int expected = (int)Math.Ceiling(_dec);
            float actual = ((float)_dec).Ceiling();

            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Ceiling_ReturnsCorrectInt_OnDouble()
        {
            int expected = (int)Math.Ceiling(_dec);
            double actual = ((double)_dec).Ceiling();

            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Ceiling_ReturnsCorrectInt_OnDecimal()
        {
            int expected = (int)Math.Ceiling(_dec);
            decimal actual = ((decimal)_dec).Ceiling();

            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region Abs
        [Test()] 
        public void Abs_ReturnsCorrectValue_OnFloat()
        {
            float expected = (float)Math.Abs((float)_dec);
            float actual = ((float)_dec).Abs();

            Assert.AreEqual(expected, actual);
        }

        [Test()] 
        public void Abs_ReturnsCorrectValue_OnDouble()
        {
            double expected = (double)Math.Abs((double)_dec);
            double actual = ((double)_dec).Abs();

            Assert.AreEqual(expected, actual);
        }

        [Test()] 
        public void Abs_ReturnsCorrectValue_OnDecimal()
        {
            decimal expected = Math.Abs(_dec);
            decimal actual = (_dec).Abs();

            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region ToInt
        [Test()]
        public void ToInt_ReturnsCorrectInt_OnFloat()
        {
            long expected = (long)Math.Floor((float)_dec);
            long actual = ((float)_dec).ToInt();

            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void ToInt_ReturnsCorrectInt_OnDouble()
        {
            long expected = (long)Math.Floor((double)_dec);
            long actual = ((double)_dec).ToInt();

            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void ToInt_ReturnsCorrectInt_OnDecimal()
        {
            long expected = (long)Math.Floor(_dec);
            long actual = _dec.ToInt();

            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}

