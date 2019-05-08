using System;
using System.Collections.Generic;
using System.Text;

namespace WorkItemTracking.State.Entities.States
{
    public class Proposed : BaseState, ICommand
    {
        private WorkItem _context;
        public Proposed(WorkItem context)
        {
            _context = context;
        }

        public bool Delete()
        {
            return true;
        }

        public void Open()
        {
            _context.ChangeState(new Active(_context));
            Console.WriteLine("Work Item State has changed to Active");
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Print(_context);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Resolve()
        {
            Console.WriteLine("You can't Resolve a Proposed Work Item");
        }

        public void SetContext(WorkItem workItem)
        {
            _context = workItem;
        }

        public void Verify()
        {
            Console.WriteLine("You can't Close a Proposed Work Item");
        }
    }
}
