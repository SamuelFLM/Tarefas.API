using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task.API.Entities
{
    public class Tasks
    {
        public Tasks() { }
        public Tasks(string title, string description, bool status, DateTime deadLine)
        {
            Title = title;
            Description = description;
            Status = status;
            DeadLine = deadLine;
            RegistrationDate = DateTime.Now;
        }
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Description { get; private set; }
        public bool Status { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime DeadLine { get; private set; }

        public void Update(bool status)
        {
            Status = status;
        }
    }
}