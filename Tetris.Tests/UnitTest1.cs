namespace Tetris.Tests;

public class UnitTest1
{
    Board TestBoard = new Board();

    [Fact]
    public void CanCreateTest()
    {
        Assert.Equal(0, 0);
    }

    [Fact]
    public void CanCreateBoard()
    {
        Assert.Equal(TestBoard.CreateBoard(0, 0), new List<List<string>>() { });
    }

    [Fact]
    public void CanCreate1x1Board()
    {
        Assert.Equal(TestBoard.CreateBoard(1, 1), new List<List<string>>(){new List<string>(){" "}});
    }

    [Fact]
    public void CanCreate2x2Board()
    {
        Assert.Equal(TestBoard.CreateBoard(2, 2), new List<List<string>>(){new List<string>(){" ", " "}, new List<string>(){" ", " "}});
    }

    [Fact]
    public void CanCreate3x3Board()
    {
        Assert.Equal(TestBoard.CreateBoard(3, 3), new List<List<string>>(){new List<string>(){" ", " ", " "}, new List<string>(){" ", " ", " "}, new List<string>(){" ", " ", " "} });
    }
}