using System;

namespace Concise.Core.Numbers
{
    internal interface IIntegralMethods
    {
        long To(long source, long upperbound, Action<long> executionBlock);
        long To(long source, long upperbound, long step, 
            Action<long> executionBlock);

        long Times(long source, Action<long> executionBlock);
    }
}

