using DesktopApp;
using Xunit;

namespace DesktopAppTests;

public class GreeterTests
{
    [Fact]
    public void Greet_UsesTheNameGiven()
    {
        Assert.Equal("Hello, Robert.", Greeter.Greet("Robert"));
    }

    [Fact]
    public void Greet_FallsBackWhenNameIsBlankOrNull()
    {
        Assert.Equal("Hello, world.", Greeter.Greet(null));
        Assert.Equal("Hello, world.", Greeter.Greet("  "));
    }
}
