namespace PortTester;

[TestClass]
public class BasicUnitTests
{
    [TestMethod]
    public void TestLocalhostClosed()
    {
        // Arrange
        string ipAddress = "127.0.0.1";
        int port = 80;
        // Act
        bool isClosed = PortTester.TestPort(ipAddress, port);
        // Assert
        Assert.IsFalse(isClosed, $"Port {port} should be open on {ipAddress}.");
    }
    [TestMethod]
    public void TestGoogleDnsIsOpened()
    {
        // Arrange
        string ipAddress = "8.8.8.8";
        int port = 53;
        // Act
        bool isOpened = PortTester.TestPort(ipAddress, port);
        // Assert
        Assert.IsTrue(isOpened, $"Port {port} should be open on {ipAddress}.");
    }
}
