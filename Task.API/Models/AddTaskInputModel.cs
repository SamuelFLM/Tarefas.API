using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task.API.Models
{
    public record AddTaskInputModel(
        string Title,
        string Description,
        bool Status,
        DateTime DeadLine
    )
    {

    }
}