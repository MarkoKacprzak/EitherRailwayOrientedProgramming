using System;

namespace Demo.Abstract
{
    class Left<TLeft, TRight> : Either<TLeft, TRight>
    {
        TLeft Value { get; }

        public Left(TLeft value)
        {
            this.Value = value;
        }

        public override Either<TNewLeft, TRight> MapLeft<TNewLeft>(
            Func<TLeft, TNewLeft> mapping) =>
            new Left<TNewLeft, TRight>(mapping(this.Value));

        public override Either<TLeft, TNewRight> MapRight<TNewRight>(
            Func<TRight, TNewRight> mapping) =>
            new Left<TLeft, TNewRight>(this.Value);

        public override TLeft Reduce(Func<TRight, TLeft> mapping) =>
            this.Value;
    }
}
