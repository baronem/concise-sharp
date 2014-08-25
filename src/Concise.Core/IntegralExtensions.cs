using System;
using Concise.Core.Numbers;

namespace Concise.Core
{
    public static class IntegralExtensions
    {
        private static IIntegralMethods _intMethods;

        static IntegralExtensions()
        {
            _intMethods = new IntegralMethods();
        }

        #region short
        public static short Times(this short source, Action<long> executionBlock)
        {
            return (short)_intMethods.Times((long)source, executionBlock);
        }

        public static short To(this short source, long upperbound, 
            Action<long> executionBlock)
        {
            return (short)_intMethods.To(source, upperbound, executionBlock);
        }

        public static short To(this short source, long upperbound,
            Action<long> executionBlock, long increment)
        {
            return (short)_intMethods.To(source, upperbound, increment,
                executionBlock);
        }
        #endregion

        #region int
        public static int Times(this int source, Action<long> executionBlock)
        {
            return (int)_intMethods.Times((long)source, executionBlock);
        }

        public static int To(this int source, int upperbound, 
            Action<long> executionBlock)
        {
            return (int)_intMethods.To(source, upperbound, executionBlock);
        }

        public static int To(this int source, int upperbound,
            Action<long> executionBlock, long increment)
        {
            return (int)_intMethods.To(source, upperbound, increment,
                executionBlock);
        }
        #endregion

        #region long
        public static long Times(this long source, Action<long> executionBlock)
        {
            return _intMethods.Times(source, executionBlock);
        }

        public static long To(this long source, long upperbound, 
            Action<long> executionBlock)
        {
            return _intMethods.To(source, upperbound, executionBlock);
        }

        public static long To(this long source, long upperbound,
            Action<long> executionBlock, long increment)
        {
            return _intMethods.To(source, upperbound, increment,
                executionBlock);
        }
        #endregion
    }
}

