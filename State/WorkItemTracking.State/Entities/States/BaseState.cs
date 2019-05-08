using System;
using System.Collections.Generic;
using System.Text;

namespace WorkItemTracking.State.Entities.States
{
    public abstract class BaseState
    {
        public virtual void Print(WorkItem workItem)
        {
            Console.WriteLine("WorkItem: ");
            Console.WriteLine($"Title: { workItem.Title } ");
            Console.WriteLine($"Description: { workItem.Description}");
            Console.WriteLine($"State: { workItem.GetDescriptionState() }");
        }
    }
}
