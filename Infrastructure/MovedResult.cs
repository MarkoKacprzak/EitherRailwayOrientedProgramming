using Demo.Abstract;
using Demo.Types;
using System;

namespace Demo.Infratructure
{
    class MovedResult : Left<Failed, Resource>
    {
        public MovedResult(Uri redirectUri):base(new Moved(redirectUri)) { }
    }
}
