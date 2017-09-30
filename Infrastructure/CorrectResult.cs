using Demo.Abstract;

namespace Demo.Infratructure
{
    class CorrectResult : Right<Failed, Resource>
    {
        public CorrectResult(string resource) : base(new Resource(resource)) { }
    }
}
