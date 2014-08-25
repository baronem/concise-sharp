using System;

namespace Concise.Core.Numbers
{
    internal class IntegralMethods : IIntegralMethods
    {
        internal long ToImpl(long source, long upperbound, 
            short upperboundModifier, Action<long> executionBlock, 
            Func<long, long> incrementBlock)
        {

            for (long i = source; i < (upperbound + upperboundModifier); 
                i = incrementBlock(i)) {

                executionBlock(i);
            }

            return source;
        }

        public long To(long source, long upperbound, 
            Action<long> executionBlock)
        {
            return this.To(source, upperbound, 1, executionBlock);
        }

        public long To(long source, long upperbound, long increment, 
            Action<long> executionBlock)
        {
            long step = (source <= upperbound) 
                ? Math.Abs(increment) 
                : -Math.Abs(increment);

            return this.ToImpl(source, upperbound, 1, executionBlock, 
                ((i) => i + step));
        }

//        public long To(long source, long upperbound, Action<long> executionBlock, 
//            Func<long, long> incrementBlock)
//        {
//            return this.ToImpl(source, upperbound, 1, executionBlock, 
//                incrementBlock);
//        }

        public long Times(long source, Action<long> executionBlock)
        {
            return this.ToImpl(0, source, 0, executionBlock, ((i) => i + 1));
        }
    }
}

