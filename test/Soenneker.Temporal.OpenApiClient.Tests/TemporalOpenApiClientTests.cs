using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Temporal.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class TemporalOpenApiClientTests : FixturedUnitTest
{
    public TemporalOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
