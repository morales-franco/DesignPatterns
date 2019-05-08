using System;
using System.Collections.Generic;
using System.Text;
using WorkItemTracking.Services;

namespace WorkItemTracking.Entities
{
    public class WorkItem
    {
        //Instance Methods & Properties
        public int Id { get; private set; }
        public eState State { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }

        public WorkItem()
        {
            State = eState.Proposed;
        }

        public void ChangeState(eState state)
        {
            State = state;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public void Edit(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public void Open()
        {
            switch (State)
            {
                case eState.Proposed:
                    ChangeState(eState.Active);
                    Console.WriteLine("Work Item State has changed to Active");
                    break;
                case eState.Active:
                    Console.WriteLine("Work Item is already Active");
                    break;
                case eState.Resolved:
                    Console.WriteLine("You can't Open a Resolved Work Item");
                    break;
                case eState.Closed:
                    Console.WriteLine("Work Item is closed and can not be modified");
                    break;
                default:
                    break;
            }
        }


        public void Resolve()
        {
            switch (State)
            {
                case eState.Proposed:
                    Console.WriteLine("You can't Resolve a Proposed Work Item");
                    break;
                case eState.Active:
                    ChangeState(eState.Resolved);
                    Console.WriteLine("Work Item State has changed to Resolved");
                    break;
                case eState.Resolved:
                    Console.WriteLine("Work Item is already Resolved");
                    break;
                case eState.Closed:
                    Console.WriteLine("Work Item is closed. You can't Resolve it.");
                    break;
                default:
                    break;
            }
        }

        internal bool CanDelete()
        {
            switch (State)
            {
                case eState.Proposed:
                    return true;
                case eState.Active:
                    return false;
                case eState.Resolved:
                    return false;
                case eState.Closed:
                    return true;
                default:
                    return false;
            }
        }

        public void Verify()
        {
            switch (State)
            {
                case eState.Proposed:
                    Console.WriteLine("You can't Close a Proposed Work Item");
                    break;
                case eState.Active:
                    Console.WriteLine("You can't Close a Active Work Item");
                    break;
                case eState.Resolved:
                    ChangeState(eState.Closed);
                    Console.WriteLine("Work Item State has changed to Closed");
                    break;
                case eState.Closed:
                    Console.WriteLine("Work Item is already Closed");
                    break;
                default:
                    break;
            }
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("WorkItem: ");
            Console.WriteLine($"Title: { Title } ");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"State: { State.ToString() }");

            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
