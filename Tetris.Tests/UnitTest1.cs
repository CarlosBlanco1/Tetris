namespace Tetris.Tests;

public class UnitTest1
{
    [Fact]
    public void CanCreateTest()
    {
        Assert.Equal(0, 0);
    }

    [Fact]
    public void CanCreateBoard()
    {
        Assert.Equal(Board.CreateBoard(0, 0), new List<List<string>>() { });
    }

    [Fact]
    public void CanCreate1x1Board()
    {
        Assert.Equal(Board.CreateBoard(1, 1), new List<List<string>>(){new List<string>(),
        new List<string>()});
    }
}