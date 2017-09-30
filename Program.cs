using Demo.Infratructure;
using System;
using System.IO;
using System.Net;

namespace Demo
{
    class Program
    {
        static Abstract.Either<Types.Failed, Types.Resource> Fetch(Uri address)
        {
            var request = WebRequest.Create(address);

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.NotFound)
                    return new NotFoundResult();

                if (response.StatusCode == HttpStatusCode.Redirect ||
                            response.StatusCode == HttpStatusCode.TemporaryRedirect)
                {
                    Uri redirectUri = new Uri(response.Headers[HttpResponseHeader.Location]);
                    return new MovedResult(redirectUri);
                }

                if (response.StatusCode != HttpStatusCode.OK)
                    return new FailedResult();

                Stream dataStream = response.GetResponseStream();
                string data = new StreamReader(dataStream).ReadToEnd();
                return new CorrectResult(data);

            }
            catch (WebException ex) when (ex.Status == WebExceptionStatus.Timeout)
            {
                return new TimeoutResult();
            }
            catch (WebException)
            {
                return new NetworkErrorResult();
            }
        }

        static void Main(string[] args)
        {
            Uri address = new Uri("https://google.pl");
            var result = Fetch(address);

            string report = result
                .MapLeft(failure => $"Error fetching resource - {failure}")
                .MapRight(correct => $"{correct.Data}")
                .Reduce(resource => resource);

            Console.WriteLine(report);
        }

        static void Log(string message) { }
    }
}
