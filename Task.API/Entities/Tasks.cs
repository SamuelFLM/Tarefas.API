using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task.API.Entities
{
    public class Tasks
    {
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Description { get; private set; }
        public bool Status { get; set; }
        public DateTime Prazo { get; private set; }
    }
}