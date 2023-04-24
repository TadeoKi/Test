using TestDateFormat ;
using NUnit.Framework ;



namespace TestDateFormat;

public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestDateOk()
    {
        const string input = "24/04/2023";
        const string expected = "2023-04-24";

        string actual = DateFormatter.ChangeFormat(input);
        
        Assert.That(actual, Is.EqualTo(expected));
        
    }

    [Test]
    public void TestDateNotOk()
    {
        const string input = "135/04/2023";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);
        
        Assert.That(actual, Is.EqualTo(expected));
        
    }

    [Test]
    public void TestDateEmpty()
    {
        const string input = "";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);
        
        Assert.That(actual, Is.EqualTo(expected));
        
    }

    [Test]
    public void TestDateWrongSep()
    {
        const string input = "24-04-2023";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);
        
        Assert.That(actual, Is.EqualTo(expected));
        
    }

    [Test]
    public void TestDateWrongSep2()
    {
        const string input = "24.04.2023";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);
        
        Assert.That(actual, Is.EqualTo(expected));
        
    }
}