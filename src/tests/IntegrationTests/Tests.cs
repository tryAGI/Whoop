namespace Whoop.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static WhoopClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("WHOOP_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("WHOOP_API_KEY environment variable is not found.");

        var client = new WhoopClient(apiKey);
        
        return client;
    }
}
