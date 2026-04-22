using Soenneker.Tests.HostedUnit;

namespace Soenneker.Temporal.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class TemporalOpenApiClientTests : HostedUnitTest
{
    public TemporalOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
