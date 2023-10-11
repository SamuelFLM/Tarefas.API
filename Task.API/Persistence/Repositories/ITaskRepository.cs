using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task.API.Entities;

namespace Task.API.Persistence.Repositories
{
    public interface ITaskRepository
    {
        List<Tasks> GetAll();
        Tasks GetById(int id);
        void Post(Tasks tasks);
        void Put(Tasks tasks);
        void Delete(Tasks tasks);
    }
}