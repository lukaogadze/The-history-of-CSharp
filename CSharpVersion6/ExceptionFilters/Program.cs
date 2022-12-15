namespace ExceptionFilters
{
    internal static class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine(await MakeRequest());
        }

        public static async Task<string> MakeRequest()
        {
            var client = new HttpClient();
            var streamTask = client.GetStringAsync("https://localHost:10000");
            try
            {
                string responseText = await streamTask;
                return responseText;
            }
            catch (HttpRequestException e) when (e.Message.Contains("301"))
            {
                return "Site Moved";
            }
            catch (HttpRequestException e) when (e.Message.Contains("404"))
            {
                return "Page Not Found";
            }
            catch (HttpRequestException e)
            {
                return e.Message;
            }
        }
    }
}