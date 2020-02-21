using System;
using Xunit;

public static class PatternMatchingTest
{
    private static string EmployeeInfo =
        $"Employee's name is {PatternMatching.tom._name}, and position code "+
        $"is {PatternMatching.tom._positionCode.ToString()}";

    private static bool _equals;

    [Fact]
    public static void Test1()
    {
        var test = PatternMatching.Write();
        Assert.Equal(EmployeeInfo,test); 
    }
}
