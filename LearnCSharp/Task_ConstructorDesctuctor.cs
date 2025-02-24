namespace LearnCSharp;

public class Task_ConstructorDesctuctor
{
    private string name;
    
    public Task_ConstructorDesctuctor(string name)
    {
        this.name = name;
        Console.WriteLine($"Объект {name} создан.");
    }
    
    ~Task_ConstructorDesctuctor()
    {
        Console.WriteLine($"Объект {name} уничтожен.");
    }
    
    public void Display()
    {
        Console.WriteLine($"Имя: {name}");
    }
}