public abstract class Employee
{
    public string _name;
    public int _positionCode;

    protected Employee(string Name, int PositionCode)
    {
        _name = Name;
        _positionCode = PositionCode;
    }

    public string DisplayEmployeeInfo() =>
        $"Employee's name is {_name}, and position code is {_positionCode.ToString()}";
}

public class Ceo : Employee
{
    public Ceo(string name, int positionCode) : base(name, positionCode)
    {
    }
}

public class PersonalAssistant : Employee
{
    public PersonalAssistant(string name, int positionCode) : base(name, positionCode)
    {
    }
}