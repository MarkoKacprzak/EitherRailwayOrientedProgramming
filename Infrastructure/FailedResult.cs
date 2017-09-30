using Demo.Abstract;

namespace Demo.Infratructure
{
    class FailedResult : Left<Failed, Resource>
    {
        public FailedResult() : base(new Failed()) { }
        public FailedResult(Failed failed) : base(failed) { }
    }
}
