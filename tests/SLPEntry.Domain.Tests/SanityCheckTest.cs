using FluentAssertions;
using Xunit;

namespace SLPEntry.Domain.Tests;

public class SanityCheckTest
{
    [Fact]
    public void SanityCheck_ShouldFail_ToVerify()
    {
        int actual = 1;
        actual.Should().Be(1);

    }
}
