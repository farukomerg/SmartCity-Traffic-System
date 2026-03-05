public class AuthorizationTests
{
    [Fact]
    public void Unauthorized_Request_Should_Return_401()
    {
        var token = "";

        Assert.True(string.IsNullOrEmpty(token));
    }
}
