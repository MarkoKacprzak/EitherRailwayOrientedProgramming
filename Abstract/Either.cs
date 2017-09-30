using System;

namespace Demo.Abstract
{
    abstract class Either<TLeft, TRight>
    {
        public abstract Either<TNewLeft, TRight>
            MapLeft<TNewLeft>(Func<TLeft, TNewLeft> mapping);

        public abstract Either<TLeft, TNewRight>
            MapRight<TNewRight>(Func<TRight, TNewRight> mapping);

        public abstract TLeft Reduce(Func<TRight, TLeft> mapping);
    }
}
