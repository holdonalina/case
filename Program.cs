using System;
using System.Collections.Generic;

class Program
{
  static List<ToDoItem> todoList = new List<ToDoItem>();

  static void Main()
  {
    while (true)
    {
      Console.WriteLine("To-do list options");
      Console.WriteLine("1. Add a new to-do");
      Console.WriteLine("2. Display all to-do's");
      Console.WriteLine("3. Mark to-do as completed");
      Console.WriteLine("4. Delete a to-do");
      Console.WriteLine("5. Exit");
      Console.Write("Choose an option (1-5): ");

      string input = Console.ReadLine();

      switch (input)
      {
        case "1":
          AddTodo();
          break;
        case "2":
          DisplayTodos();
          break;
        case "3":
          MarkCompleted();
          break;
        case "4":
          DeleteTodo();
          break;
        case "5":
          Console.WriteLine("Thx, byeeee!");
          return;
        default:
          Console.WriteLine("Invalid option, enter a number between 1 and 5");
          break;
      }
    }
  }

  static void AddTodo()
  {
    Console.Write("Enter the name of the new to-do: ");
    string name = Console.ReadLine()?.Trim();

    if (string.IsNullOrEmpty(name))
    {
      Console.WriteLine("To-do name can't be empty");
      return;
    }

    todoList.Add(new ToDoItem(name));
    Console.WriteLine("To-do successfully added");
  }

  static void DisplayTodos()
  {
    if (todoList.Count == 0)
    {
      Console.WriteLine("To-do list is empty");
      return;
    }

    Console.WriteLine("\nTo-do list:");
    for (int i = 0; i < todoList.Count; i++)
    {
      Console.WriteLine($"{i + 1}. {todoList[i]}");
    }
  }

  static void MarkCompleted()
  {
    if (todoList.Count == 0)
    {
      Console.WriteLine("Nothing to mark, the list is empty");
      return;
    }

    DisplayTodos();
    Console.Write("Enter the number of the to-do to mark as completed: ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
      if (number >= 1 && number <= todoList.Count)
      {
        todoList[number - 1].IsCompleted = true;
        Console.WriteLine("To-do marked as completed");
      }
      else
      {
        Console.WriteLine("Invalid number, try again");
      }
    }
    else
    {
      Console.WriteLine("Invalid input, enter a number");
    }
  }

  static void DeleteTodo()
  {
    if (todoList.Count == 0)
    {
      Console.WriteLine("Nothing to delete, list is empty");
      return;
    }

    DisplayTodos();
    Console.Write("Enter the number of the to-do to delete: ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
      if (number >= 1 && number <= todoList.Count)
      {
        todoList.RemoveAt(number - 1);
        Console.WriteLine("To-do deleted");
      }
      else
      {
        Console.WriteLine("Invalid number, try again");
      }
    }
    else
    {
      Console.WriteLine("Invalid input, enter a number");
    }
  }
}