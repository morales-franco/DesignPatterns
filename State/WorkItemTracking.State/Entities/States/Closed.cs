using System;
using System.Collections.Generic;
using System.Text;

namespace WorkItemTracking.State.Entities.States
{
    public class Closed : BaseState, ICommand
    {
        private WorkItem _context;

        public Closed(WorkItem context)
        {
            context = _context;
        }

        public bool Delete()
        {
            return true;
        }

        public void Open()
        {
            Console.WriteLine("Work Item is closed and can not be modified");
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Print(_context);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Resolve()
        {
            Console.WriteLine("Work Item is closed. You can't Resolve it.");
        }

        public void SetContext(WorkItem workItem)
        {
            _context = workItem;
        }

        public void Verify()
        {
            Console.WriteLine("Work Item is already Closed");
        }
    }
}
