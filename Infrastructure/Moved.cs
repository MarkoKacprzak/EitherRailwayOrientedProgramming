using System;

namespace Demo.Infratructure
{
    class Moved : Failed
    {
        public Uri MovedTo { get; }
        public Moved(Uri movedTo)
        {
            this.MovedTo = movedTo;
        }
    }
    class MovedResult:FailedResult
    {
        public MovedResult(Uri redirectUri):base(new Moved(redirectUri)) { }
    }
}
