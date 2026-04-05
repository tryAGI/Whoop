/*
order: 20
title: AIFunction Tools
slug: tools

Shows how to use Whoop as MEAI AIFunction tools with any IChatClient.
*/

using tryAGI.Whoop;

namespace Whoop.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AIFunctions()
    {
        //// Use Whoop tools with any MEAI-compatible AI provider
        using var client = new WhoopClient(apiKey: "test");
        var tools = client.AsTools();
        tools.Count.Should().BeGreaterThan(0);
    }
}
