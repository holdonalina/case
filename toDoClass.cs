using System;

public class ToDoItem
{
    public string Name { get; set; }
    public bool IsCompleted { get; set; }

    public ToDoItem(string name)
    {
        Name = name;
        IsCompleted = false;
    }

    public override string ToString()
    {
        return IsCompleted ? $"[✓] {Name}" : $"[ ] {Name}";
    }
}
