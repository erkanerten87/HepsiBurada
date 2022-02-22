
using HepsiBuradaProject;
using Xunit;

namespace HepsiBuradaProjectUnitTests;

public class HovardTest
{
   [Fact]
    public void MoveForwardTest()
    {
            Rover rover = new Rover("0","0","N","5","5");
            rover.MoveAll("M");
            Assert.Equal("0 1 N",rover.GetLatestLocation());
    }

     [Fact]
    public void MovForwardWithExtension()
    {
            Rover rover = new Rover("0","0","N","5","5");
            rover.MoveAll("MMMMMMMMMMMMM");
            Assert.Equal("0 5 N",rover.GetLatestLocation());
    }

    [Fact]
    public void Example1Test()
    {
        Rover rover = new Rover("1","2","N","5","5");
        rover.MoveAll("LMLMLMLMM");
        Assert.Equal("1 3 N",rover.GetLatestLocation());
    }

    [Fact]
    public void Example2Test()
    {
        Rover rover = new Rover("3","3","E","5","5");
        rover.MoveAll("MMRMMRMRRM");
        Assert.Equal("5 1 E",rover.GetLatestLocation());
    }
}