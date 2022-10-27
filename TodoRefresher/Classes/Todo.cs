namespace TodoRefresher.Classes;
public class Todo
  {
    private string taskName { get; set; }
    private TaskPriority taskPriority { get; set; }
    private TaskType taskType  { get; set; }
    private int taskDuration { get; set; }
    private string taskDescription { get; set; }
    public bool isComplete { get; set; }
    public Todo(string name, TaskPriority priority, TaskType type, int duration, string description)
    {
      taskName = name;
      taskPriority = priority;
      taskType = type;
      taskDuration = duration;
      taskDescription = description;
      isComplete = false;
    }
    public void CheckIsComplete()
    {
      if(isComplete)
        Console.WriteLine($"{taskName} is complete");
      else
        Console.WriteLine($"{taskName} is not complete");
    }
    public void UpdateTaskDuration()
    {
      Console.WriteLine("What is the updated task duration in minutes?");
      string updatedDuration = Console.ReadLine();
      taskDuration = Convert.ToInt32(updatedDuration);
      Console.WriteLine($"Duration has been updated to {taskDuration} minutes");
    }
    public void OutputTodo()
    {
      Console.WriteLine($"{taskName} is a {taskType} task type with {taskPriority} priority. This task should take {taskDuration} minutes.");

      Console.WriteLine(isComplete ? $"{taskName} is complete" : $"{taskName} is not complete");

      Console.WriteLine("Enter: YES to see the task description or NO to exit");
      string yesOrNo = Console.ReadLine();
      switch (yesOrNo.ToLower())
      {
        case "yes":
          Console.WriteLine($"Task Description: {taskDescription}");
          break;
        case "y":
          Console.WriteLine($"Task Description: {taskDescription}");
          break;
        case "no":
          break;
        case "n":
          break;
        default:
          Console.WriteLine("Not a valid response");
          break;
      }
    }
  }
  public enum TaskType
  {
    Personal, Professional, Other
  }
  public enum TaskPriority
  {
    High, Medium, Low
  }


// namespace TodoRefresher.Classes
// {
//   public class Todo
//   {
//     private string taskName { get; set; }
//     private TaskPriority taskPriority { get; set; }
//     private TaskType taskType  { get; set; }
//     private int taskDuration { get; set; }
//     private string taskDescription { get; set; }
//     public bool isComplete { get; set; }
//     public Todo(string name, TaskPriority priority, TaskType type, int duration, string description)
//     {
//       taskName = name;
//       taskPriority = priority;
//       taskType = type;
//       taskDuration = duration;
//       taskDescription = description;
//       isComplete = false;
//     }
//     public void CheckIsComplete()
//     {
//       if(isComplete)
//         Console.WriteLine($"{taskName} is complete");
//       else
//         Console.WriteLine($"{taskName} is not complete");
//     }
//     public void UpdateTaskDuration()
//     {
//       Console.WriteLine("What is the updated task duration in minutes?");
//       string updatedDuration = Console.ReadLine();
//       taskDuration = Convert.ToInt32(updatedDuration);
//       Console.WriteLine($"Duration has been updated to {taskDuration} minutes");
//     }
//     public void OutputTodo()
//     {
//       Console.WriteLine($"{taskName} is a {taskType} task type with {taskPriority} priority. This task should take {taskDuration} minutes.");
//       Console.WriteLine(isComplete ? $"{taskName} is complete" : $"{taskName} is not complete");
//       Console.WriteLine("Enter: YES to see the task description or NO to exit");
//       string yesOrNo = Console.ReadLine();
//       switch (yesOrNo.ToLower())
//       {
//         case "yes":
//           Console.WriteLine($"Task Description: {taskDescription}");
//           break;
//         case "y":
//           Console.WriteLine($"Task Description: {taskDescription}");
//           break;
//         case "no":
//           break;
//         case "n":
//           break;
//         default:
//           Console.WriteLine("Not a valid response");
//           break;
//       }
//     }
//   }
//   public enum TaskType
//   {
//     Personal, Professional, Other
//   }
//   public enum TaskPriority
//   {
//     High, Medium, Low
//   }
// }