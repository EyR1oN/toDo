using Business_Logic_Layer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Interfaces
{
    public interface IToDoBLL
    {
        public Task<List<ToDoModel>> GetToDoList();

        public Task<ToDoModel> GetToDoById(int id);

        public Task<IActionResult> PostToDo(ToDoModel toDoModel);

        public Task<IActionResult> DeleteToDo(int id);

        public Task<IActionResult> PutToDo(ToDoModel toDoModel);

    }
}
