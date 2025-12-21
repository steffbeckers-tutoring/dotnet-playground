using Playground.ClassLibrary.ProgrammingAdvancedCup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.xUnit.ProgrammingAdvancedCup;

public class WimbledonTests
{
    private readonly Wimbledon _wimbledon;

    public WimbledonTests()
    {
        _wimbledon = new Wimbledon();
    }

    [Theory]
    [InlineData(
        "Oea  ie.mtat n",
        "One at a time.")]
    [InlineData(
        "W'entwies u o,cnw ev.erse a ybtb,rta o re",
        "We're not waiters, but boy, can we serve.")]
    public void Should_Decrypt_Message(string encryptedMessage, string decryptedMessage)
    {
        Assert.Equal(decryptedMessage, _wimbledon.Decrypt(encryptedMessage));
    }
}