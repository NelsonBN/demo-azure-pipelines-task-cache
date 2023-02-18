using Xunit;

namespace Demo.Lib.Tests;

public class UtilsTest
{
    [Fact]
    public void PT_GetCountry_Portugal()
    {
        // Arrange
        var iso2 = "PT";


        // Act
        var act = Utils.GetCountry(iso2);


        // Assert
        Assert.Equal("Demo: Portugal", act);
    }
}
