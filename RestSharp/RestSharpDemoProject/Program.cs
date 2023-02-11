using RestSharp;

namespace RestSharpDemoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://api.github.com");
            RestRequest request = new RestRequest("repos/{user}/{repoName}/issues/1", Method.Get);

            request.AddUrlSegment("user","");
            request.AddUrlSegment("repoName","");
        }
    }
}