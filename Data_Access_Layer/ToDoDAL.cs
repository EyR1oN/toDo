using Data_Access_Layer.Repository;
using Data_Access_Layer.Repository.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class ToDoDAL : ControllerBase
    {
        public async Task<List<ToDo>> GetToDoList()
        {
            var db = new ToDoListDbContext();
            return await db.ToDos.ToListAsync();
        }

        public async Task<ToDo> GetToDoById(int id)
        {
            var db = new ToDoListDbContext();
            ToDo todo = new ToDo();
            todo = await db.ToDos.FirstOrDefaultAsync(x => x.Id == id);

            return todo;
        }

        public async Task<IActionResult> PostToDo(ToDo todo)
        {
            var db = new ToDoListDbContext();
            await db.AddAsync(todo);
            await db.SaveChangesAsync();
            return Ok();
        }

        public async Task<IActionResult> DeleteToDo(int id)
        {
            var db = new ToDoListDbContext();
            ToDo todo = db.ToDos.FirstOrDefault(x => x.Id == id);
            db.ToDos.Remove(todo);
            await db.SaveChangesAsync();
            return Ok();
        }

        public async Task<IActionResult> PutToDo(ToDo toDo)
        {
            var db = new ToDoListDbContext();
            db.Update(toDo);
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}
