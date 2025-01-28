namespace DemoBranchingTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        
        Assert.True(true);
    }

    [Fact]
    public void Test2()
    {
        //dumbo code
        Assert.False(true);
        Assert.False(false);
    }
}
