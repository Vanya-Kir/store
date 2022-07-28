namespace Store.Tests;

public class BookTests
{
    [Fact]
    public void IsIsbn_WithNull_ReturnFalse()
    {
        bool actual = Book.IsIsbn(null);
        Assert.False(actual);
    }

    [Fact]
    public void IsIsbn_WithBlancString_ReturnFalse()
    {
        bool actual = Book.IsIsbn("  ");
        Assert.False(actual);
    }

    [Fact]
    public void IsIsbn_WithIsbn9_ReturnFalse()
    {
        bool actual = Book.IsIsbn("ISBN 123456789");
        Assert.False(actual);
    }

    [Fact]
    public void IsIsbn_WithIsbn10_ReturnTrue()
    {
        bool actual = Book.IsIsbn("ISBN 12 3-45 678-90");
        Assert.True(actual);
    }

    [Fact]
    public void IsIsbn_WithIsbn13_ReturnTrue()
    {
        bool actual = Book.IsIsbn("IsbN 123-465-789 0 - 123");
        Assert.True(actual);
    }

}