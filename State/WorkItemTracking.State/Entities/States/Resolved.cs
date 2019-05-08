using System;
using System.Collections.Generic;
using System.Text;

namespace WorkItemTracking.State.Entities.States
{
    public class Resolved : BaseState, ICommand
    {
        private WorkItem _context;

        public Resolved(WorkItem context)
        {
            _context = context;
        }

        public bool Delete()
        {
            return false;
        }

        public void Open()
        {
            Console.WriteLine("You can't Open a Resolved Work Item");
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Print(_context);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Resolve()
        {
            Console.WriteLine("The work Item state is already Resolve");
        }

        public void SetContext(WorkItem workItem)
        {
            _context = workItem;
        }

        public void Verify()
        {
            _context.ChangeState(new Closed(_context));
            Console.WriteLine("Work Item State has changed to Closed");
        }
    }
}
