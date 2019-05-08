using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkItemTracking.State.Entities;

namespace WorkItemTracking.State.Services
{
    public class WorkItemService
    {
        private static List<WorkItem> DataSource;

        public WorkItemService()
        {
            DataSource = new List<WorkItem>();
        }

        public WorkItem GetById(int id)
        {
            return DataSource.FirstOrDefault(wi => wi.Id == id);
        }

        public void Create(WorkItem workItem)
        {
            int maxId = 0;

            if (DataSource.Any())
            {
                maxId = DataSource.Select(wi => wi.Id).Max();
            }

            workItem.SetId(++maxId);

            DataSource.Add(workItem);
        }

        public void Edit(WorkItem workItem)
        {
            var workItemBd = GetById(workItem.Id);

            if (workItemBd == null)
                throw new NullReferenceException($"WI: { workItem.Id } Not Found");

            workItemBd.Edit(workItem.Title, workItem.Description);
        }

        public void Delete(WorkItem workItem)
        {
            var workItemBd = GetById(workItem.Id);

            if (workItemBd == null)
                throw new NullReferenceException($"WI: { workItem.Id } Not Found");

            DataSource.Remove(workItemBd);
        }

    }
}
