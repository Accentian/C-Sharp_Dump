using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create List of todos
            List<Todo> todos = new List<Todo>()
            {
                new Todo {Description = "Grocery Shop", EstimatedHours = 2,
                    Status = Status.NotStarted, Days = Days.Friday},

                new Todo {Description = "Pick up kid", EstimatedHours = 1,
                    Status = Status.Completed, Days = Days.Monday},

                new Todo {Description = "Laundry", EstimatedHours = 3,
                    Status = Status.InProg, Days = Days.Saturday},

                new Todo {Description = "Cook Dinner", EstimatedHours = 2,
                    Status = Status.OnHold, Days = Days.Tuesday},
            };

            PrintTasks(todos);

            // Pause
            Console.ReadLine();

        } // End main

        private static void PrintTasks(List<Todo> todos)
        {
            foreach (var task in todos)
            {
                switch (task.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case Status.InProg:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    default:
                        break;
                } // End switch

                Console.WriteLine(task.Description);

            } // End foreach

            foreach (var task1 in todos)
            {
                switch (task1.Days)
                {
                    case Days.Monday:
                        Console.WriteLine(task1.Description + " will be done on Monday");
                        break;
                    case Days.Tuesday:
                        Console.WriteLine(task1.Description + " will be done on Tuesday");
                        break;
                    case Days.Wednesday:
                        Console.WriteLine(task1.Description + " will be done on Wednesday");
                        break;
                    case Days.Thursday:
                        Console.WriteLine(task1.Description + " will be done on Thursday");
                        break;
                    case Days.Friday:
                        Console.WriteLine(task1.Description + " will be done on Friday");
                        break;
                    case Days.Saturday:
                        Console.WriteLine(task1.Description + " will be done on Saturday");
                        break;
                    case Days.Sunday:
                        Console.WriteLine(task1.Description + " will be done on Sunday");
                        break;
                } // End switch
            } // End foreach
        } // End method

    } // End class

    class Todo
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }
        public Days Days { get; set; }

    } // End class Todo

    enum Status
    {
        NotStarted,
        InProg,
        OnHold,
        Completed,
        Deleted
    } // End Status enum

    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    } // End Days enum

} // End namespace
