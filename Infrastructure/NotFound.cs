namespace Demo.Infratructure
{
    class NotFound : Failed { }
    class NotFoundResult : FailedResult
    {
        public NotFoundResult() : base(new NotFound()) { }
    }
}
