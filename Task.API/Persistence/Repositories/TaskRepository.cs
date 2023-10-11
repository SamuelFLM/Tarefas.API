using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task.API.Entities;

namespace Task.API.Persistence.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskContext _context;

        public TaskRepository(TaskContext context)
        {
            _context = context;
        }

        public void Delete(Tasks tasks)
        {
            _context.Requests.Remove(tasks);
            _context.SaveChanges();
        }

        public List<Tasks> GetAll()
        {
            return _context.Requests.AsNoTracking().ToList();
        }

        public Tasks GetById(int id)
        {
            return _context.Requests.SingleOrDefault(x => x.Id == id);
        }

        public void Post(Tasks tasks)
        {
            _context.Requests.Add(tasks);
            _context.SaveChanges();
        }

        public void Put(Tasks tasks)
        {
            _context.Requests.Update(tasks);
            _context.SaveChanges();
        }
    }
}