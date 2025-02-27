namespace Animals.Tests;

public class UnitTest1
{
    [Fact]
    public void TalkToOwnerReturnsWhat()
    {
        string expected = "what?!";
        string actual = new Animal("rex").TalkToOwner();

        //failing the test 
        Assert.NotEqual(expected, actual);
    }
}


//dotnet add Animals.Tests/Animals.Tests.csproj reference Animals/Animals.csproj