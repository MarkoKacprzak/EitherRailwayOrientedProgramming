using Demo.Abstract;
using Demo.Types;

namespace Demo.Infratructure
{
    class TimeoutResult : Left<Failed, Resource>
    {
        public TimeoutResult():base(new Timeout()) { }
    }
}
