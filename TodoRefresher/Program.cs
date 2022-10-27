using TodoRefresher.Classes;

namespace TodoRefresher
{
  class Program
  {
    static void Main(string[] args)
    {
      // Console.WriteLine("We're gonna make a todo list in C#!");

      // List<Todo> myTodoList = CreateTodoList();

      // myTodoList[0].OutputTodo();
      // myTodoList[0].UpdateTaskDuration();
      // myTodoList[0].OutputTodo();
      // myTodoList[1].CheckIsComplete();
      // myTodoList[1].isComplete = true;
      // myTodoList[1].CheckIsComplete();

      // foreach(var todo in myTodoList)
      //   todo.OutputTodo();

      UserInterface();
    }

    static void CreateNewTodo(List<Todo> userTodoList)
    {
      Console.WriteLine("Name: ");
      string name = Console.ReadLine();
      Console.WriteLine("Priority level: high, medium, or low ");
      TaskPriority priority = (TaskPriority)Enum.Parse(typeof(TaskPriority), Console.ReadLine());
      Console.WriteLine("Type: personal, professional, or other ");
      TaskType type = (TaskType)Enum.Parse(typeof(TaskType), Console.ReadLine());
      Console.WriteLine("Duration in minutes: ");
      int duration = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Description: ");
      string description = Console.ReadLine();
      
      userTodoList.Add(new Todo(name, priority, type, duration, description));

      Console.WriteLine("Todo added");
    }

    static void ViewTodos(List<Todo> userTodoList)
    {
      Console.WriteLine("Here's your todo list: \n");
      foreach(var todo in userTodoList)
        todo.OutputTodo();
    }

    static void MarkComplete(List<Todo> userTodoList)
    {
      // 1. Need to know what task i want to mark complete
      Console.WriteLine($"There are {userTodoList.Count} items in your todo list");
      Console.WriteLine($"What task would you like to complete? Pick todo from 1 - {userTodoList.Count}");

      int answer = Convert.ToInt32(Console.ReadLine());
      
      // 2. Mark it as complete
      userTodoList[answer - 1].isComplete = true;

      Console.WriteLine("Todo marked complete");
      userTodoList[answer - 1].OutputTodo();
      // 3. Check how many tasks are left that are not complete


    }

    static void UserInterface()
    {
      Console.WriteLine("Welcome to this todo list app!");
      List<Todo> userTodoList = new List<Todo>();
      while(true)
      {
        Console.WriteLine("Here are our options:\n 1. Create new todo\n2.View all todos\n3.Mark todo complete\n4.Exit");
        string answer = Console.ReadLine();
        switch (answer)
        {
          case "1":
            CreateNewTodo(userTodoList);
            break;
          case "2":
            ViewTodos(userTodoList);
            break;
          case "3":
            MarkComplete(userTodoList);
            break;
          case "4":
            Console.WriteLine("Exiting. Thanks");
            return;
          default:
            break;
        }
      }
    }

    // static List<Todo> CreateTodoList()
    // {
    //   List<Todo> myTodoList = new List<Todo>(){
    //     new Todo("Feed the cat", TaskPriority.High, TaskType.Other, 3, "I have to feed and water Korjei"),
    //     new Todo("Pack", TaskPriority.Medium, TaskType.Personal, 3, "I have to pack for my upcoming trip"),
    //     new Todo("Laundry", TaskPriority.High, TaskType.Personal, 3, "I have to do my laundry, then fold after"),
    //     new Todo("Eat", TaskPriority.Medium, TaskType.Personal, 3, "I have to feed myself since i haven't eaten today"),
    //     new Todo("Code", TaskPriority.High, TaskType.Professional, 3, "I have to code and imporve my skillset"),
    //   };
      
    //   return myTodoList;
    // }
  }
}