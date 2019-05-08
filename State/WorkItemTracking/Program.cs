using System;
using System.Linq;
using WorkItemTracking.Entities;
using WorkItemTracking.Services;

namespace WorkItemTracking
{
    /*
     * Implementation without State Pattern
     */
    class Program
    {
        static void Main(string[] args)
        {
            var workItemService = new WorkItemService();

            while (true)
            {
                Console.WriteLine("--------------------------");
                PrintUsage();

                string command = Console.ReadLine();

                if (command.ToLower().Trim() == "quit")
                    return;

                // Parse the arguments
                string cmd, title = null, desc = null;
                int id;
                try
                {
                    var arguments = command.Split(" ").Where(x => x != "").ToArray();
                    cmd = arguments[0].ToLower();
                    id = int.Parse(arguments[1]);
                    if (arguments.Count() > 2)
                    {
                        title = arguments[2];
                        desc = arguments[3];
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error");
                    continue;
                }

                var wi = workItemService.GetById(id);
                // Execute Command
                try
                {
                    switch (cmd.ToLower())
                    {
                        case "create":
                            wi = new WorkItem();
                            workItemService.Create(wi);
                            wi.Edit(title, desc);
                            wi.Print();
                            break;
                        case "delete":
                            if (wi.CanDelete())
                                workItemService.Delete(wi);
                            break;
                        case "edit":
                            wi.Edit(title, desc);
                            workItemService.Edit(wi);
                            break;
                        case "open":
                            wi.Open();
                            workItemService.Edit(wi);
                            break;
                        case "resolve":
                            wi.Resolve();
                            workItemService.Edit(wi);
                            break;
                        case "verify":
                            wi.Verify();
                            workItemService.Edit(wi);
                            break;
                        case "print":
                            wi.Print();
                            break;
                        default:
                            PrintUsage();
                            continue;
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unable to perform operation. " + ex.Message);
                    PrintUsage();
                }

            }
        }

        private static void PrintUsage()
        {
            Console.WriteLine("Usage: state <command> <id> <title> <description>");
            Console.WriteLine("Commands: create, edit, open, resolve, verify, print, delete");
            Console.WriteLine("States: Proposed, Active, Resolved, Closed");
            Console.WriteLine("Press <quit> to finish");
        }
    }
}
