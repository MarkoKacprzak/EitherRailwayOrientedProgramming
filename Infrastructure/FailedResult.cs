using Demo.Abstract;
using Demo.Types;

namespace Demo.Infratructure
{
    class FailedResult : Left<Failed, Resource>
    {
        public FailedResult() : base(new Failed()) { }
    }
}
