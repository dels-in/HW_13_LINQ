namespace HW_13;

public class User
{
    public int Age { get; set; }
    private string _name;
    public User(int age, string name)
    {
        Age = age;
        _name = name;
    }
}