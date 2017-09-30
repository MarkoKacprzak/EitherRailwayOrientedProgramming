using Demo.Abstract;
using Demo.Types;

namespace Demo.Infratructure
{
    class NotFoundResult : Left<Failed, Resource>
    {
        public NotFoundResult() : base(new NotFound()) { }
    }
}
