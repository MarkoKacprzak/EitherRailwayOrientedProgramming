﻿using System;

namespace Demo.Abstract
{
    class Right<TLeft, TRight> : Either<TLeft, TRight>
    {
        TRight Value { get; }

        public Right(TRight value)
        {
            this.Value = value;
        }

        public override Either<TNewLeft, TRight> MapLeft<TNewLeft>(
            Func<TLeft, TNewLeft> mapping) =>
            new Right<TNewLeft, TRight>(this.Value);

        public override Either<TLeft, TNewRight> MapRight<TNewRight>(
            Func<TRight, TNewRight> mapping) =>
            new Right<TLeft, TNewRight>(mapping(this.Value));

        public override TLeft Reduce(Func<TRight, TLeft> mapping) =>
            mapping(this.Value);
    }
}
