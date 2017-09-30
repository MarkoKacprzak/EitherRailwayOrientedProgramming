using Demo.Abstract;
using Demo.Types;

namespace Demo.Infratructure
{
    class NetworkErrorResult : Left<Failed, Resource>
    {
        public NetworkErrorResult() : base(new NetworkError()) { }
    }
}
