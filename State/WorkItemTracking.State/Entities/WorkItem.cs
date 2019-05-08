using System;
using System.Collections.Generic;
using System.Text;
using WorkItemTracking.State.Entities.States;

namespace WorkItemTracking.State.Entities
{
    public class WorkItem
    {
        //Instance Methods & Properties
        public int Id { get; private set; }

        //Internal State
        //When the Internal State changes --> the behaviour changes too
        private  ICommand _StateCommand; 

        public string Title { get; private set; }
        public string Description { get; private set; }

        internal string GetDescriptionState()
        {
            return _StateCommand.GetType().Name;
        }

        public WorkItem()
        {
            //Initial State
            _StateCommand = new Proposed(this);
        }

        public void ChangeState(ICommand state)
        {
            _StateCommand = state;
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
            _StateCommand.Open();
        }

        public void Resolve()
        {
            _StateCommand.Resolve();
        }

        public void Verify()
        {
            _StateCommand.Verify();
        }

        public void Print()
        {
            _StateCommand.Print();
        }

        internal bool CanDelete()
        {
            return _StateCommand.Delete();
        }
    }
}
