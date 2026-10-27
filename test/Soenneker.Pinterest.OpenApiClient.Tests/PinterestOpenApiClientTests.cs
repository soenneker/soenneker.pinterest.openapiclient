using Soenneker.Tests.HostedUnit;

namespace Soenneker.Pinterest.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class PinterestOpenApiClientTests : HostedUnitTest
{
    public PinterestOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
