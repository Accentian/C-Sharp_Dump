using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create List
            List<HelpDeskCalls> helpDesks = new List<HelpDeskCalls>()
            {
                new HelpDeskCalls {Description = "404 Error", DateReported = "2/2/2019",
                    Status = Status.InProg, Priority = Priority.High, Person = "Jack",
                    Notes = ""},
                new HelpDeskCalls {Description = "Mising Image", DateReported = "1/6/2019",
                    Status = Status.Completed, Priority = Priority.Low, Person = "Micheal",
                    Notes = ""},
                new HelpDeskCalls {Description = "Replace Content", DateReported = "2/16/2019",
                    Status = Status.NotStarted, Priority = Priority.Medium, Person = "Brandon",
                    Notes = ""},
                new HelpDeskCalls {Description = "Misspelled Homepage", DateReported = "2/18/2019",
                    Status = Status.NotStarted, Priority = Priority.Medium, Person = "Jenny",
                    Notes = ""},
                new HelpDeskCalls {Description = "Server Crashing", DateReported = "2/24/2019",
                    Status = Status.Unresolved, Priority = Priority.High, Person = "Damond",
                    Notes = ""},
            };

            HelpDeskTask(helpDesks);

            Console.ReadLine();

        } // End main

        private static void HelpDeskTask(List<HelpDeskCalls> helpDesks)
        {
            foreach (var task in helpDesks)
            {
                switch (task.Status)
                {
                    case Status.NotStarted:
                        task.Notes = "Just reported";
                        break;
                    case Status.InProg:
                        task.Notes = "Help Desk personnel on scene";
                        break;
                    case Status.Completed:
                        task.Notes = "Ticket is complete";
                        break;
                    case Status.Unresolved:
                        task.Notes = "Ongoing investigation";
                        break;
                    default:
                        break;
                } // End switch

                Console.WriteLine("{0}   {1}   {2}   {3}   {4}   {5}", 
                    task.Description, task.DateReported,
                    task.Status, task.Priority, 
                    task.Person, task.Notes);

            } // End foreach

            Console.WriteLine("------------------------");


            foreach (var priority in helpDesks)
            {
                switch (priority.Priority)
                {
                    case Priority.Low:
                        Console.WriteLine("The problem is on the back-burner.");
                        break;
                    case Priority.Medium:
                        Console.WriteLine("The problem is important.");
                        break;
                    case Priority.High:
                        Console.WriteLine("The problem is critical.");
                        break;
                } // End switch

            } // End second foreach

        } // End method

    } // End class

        class HelpDeskCalls
    {
        public string Description { get; set; }
        public string DateReported { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public string Person { get; set; }
        public string Notes { get; set; }
    } // End HelpDeskClass

    enum Status
    {
        NotStarted,
        InProg,
        Completed,
        Unresolved
    } // End Status enum

    enum Priority
    {
        Low,
        Medium,
        High
    } // End Priority enum
    
} // End namespace