using System;

public static class PatternMatching
{
    public static Ceo tom = new Ceo("Tom",1);
    public static PersonalAssistant jim = new PersonalAssistant("Jim", 2);
    public static string Write() => tom.DisplayEmployeeInfo();
}