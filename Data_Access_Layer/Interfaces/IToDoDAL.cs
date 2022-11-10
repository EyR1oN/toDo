using Data_Access_Layer.Repository.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Interfaces
{
    public interface IToDoDAL
    {
        public Task<List<ToDo>> GetToDoList();

        public Task<ToDo> GetToDoById(int id);

        public Task<IActionResult> PostToDo(ToDo todo);

        public Task<IActionResult> DeleteToDo(int id);

        public Task<IActionResult> PutToDo(ToDo toDo);
    }
}
