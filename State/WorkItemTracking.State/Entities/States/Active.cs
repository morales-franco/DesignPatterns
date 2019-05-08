using System;
using System.Collections.Generic;
using System.Text;

namespace WorkItemTracking.State.Entities.States
{
    public class Active : BaseState, ICommand
    {
        private WorkItem _context;

        public Active(WorkItem context)
        {
            _context = context;
        }

        public bool Delete()
        {
            return false;
        }


        public void Open()
        {
            Console.WriteLine("Work Item is already Active");
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Print(_context);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Resolve()
        {
            _context.ChangeState(new Resolved(_context));
            Console.WriteLine("Work Item State has changed to Resolved");
        }

        public void SetContext(WorkItem workItem)
        {
            _context = workItem;
        }

        public void Verify()
        {
            Console.WriteLine("You can't Close a Active Work Item");
        }
    }
}
