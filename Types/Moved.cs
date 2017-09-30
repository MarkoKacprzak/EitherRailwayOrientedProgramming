using System;

namespace Demo.Types
{
    class Moved : Failed
    {
        public Uri MovedTo { get; }
        public Moved(Uri movedTo)
        {
            this.MovedTo = movedTo;
        }
    }
}
