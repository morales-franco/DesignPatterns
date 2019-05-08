using System;
using System.Collections.Generic;
using System.Text;

namespace WorkItemTracking.State.Entities.States
{
    /*
     * Commands whose behaviours depend on INTERNAL STATE
     */
    public interface ICommand
    {
        void SetContext(WorkItem workItem);
        void Open();
        void Resolve();
        void Verify();
        bool Delete();
        void Print();
    }
}
